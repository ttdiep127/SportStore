using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.Domain.Helpers;
using System;
using System.Linq;
using System.Text;

namespace SportsStore.Domain.Concrete
{
    public class EmailOrderProcessor : IOrderProcessor
    {
        private ShoeStoreEntities _context = new ShoeStoreEntities();
        public void ProcessorOrder(
            ShippingDetails shippingDetail,
            Cart cart
            )
        {
            //save database
            // check email

            var customer = _context.Customers.FirstOrDefault(_ => _.Email == shippingDetail.Email);

            if (customer == null)
            {
                customer = new Customer();
                customer.CustomerName = shippingDetail.FullName;
                customer.Email = shippingDetail.Email;
                customer.Address = shippingDetail.Address;
                _context.Customers.Add(customer);
            }

            _context.SaveChanges();

            var order = new Order()
            {
                CustomerId = customer.CustomerId,
                OrderDateTime = DateTime.Now,
                Note = shippingDetail.Note
            };
            _context.Orders.Add(order);

            _context.SaveChanges();
            //cart
            foreach (var line in cart.LineCollection)
            {
                var detail = new OrderDetail()
                {
                    OrderId = order.OrderId,
                    ProductId = line.Product.ProductID,
                    Quantity = line.Quatity,
                    Price = line.Product.Price
                };
                _context.OrderDetails.Add(detail);
            }
            _context.SaveChanges();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<ol>");

            foreach (var line in cart.LineCollection)
            {
                stringBuilder.Append("<li>");
                stringBuilder.Append(line.Product.ProductName);
                stringBuilder.Append(" <span>(" + line.Quatity + "x" + line.Product.Price);
                stringBuilder.Append(" = " + line.Quatity * line.Product.Price);
                stringBuilder.Append(")<span>");

                stringBuilder.Append("</li>");
            }
            stringBuilder.Append("</ol>");

            stringBuilder.Append("<h3> Tong Tien" + cart.ComputerTotal().ToString() + "</h3>");
            //email
            EmailHelper emailHelper = new EmailHelper();
            emailHelper.Send("Don hang #" + order.OrderId,
                shippingDetail.Email,
                stringBuilder.ToString(),
                null,
                null);
        }
    }
}
