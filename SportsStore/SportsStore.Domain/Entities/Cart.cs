using SportsStore.Domain.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Domain.Entities
{
    public class Cart
    {
        public List<CartLine> LineCollection { get; set; }

        public Cart()
        {
            LineCollection = new List<CartLine>();
        }

        //add
        public void Add(Product product, int quantity)
        {
            var currentCartLine = LineCollection.Where(_ => _.Product.ProductID == product.ProductID).FirstOrDefault();

            if (currentCartLine != null)
            {
                currentCartLine.Quatity += quantity;
            }
            else
            {
                var newCartLine = new CartLine();
                newCartLine.Product = product;
                newCartLine.Quatity = quantity;

                LineCollection.Add(newCartLine);
            }
        }

        //remove
        public void Remove(Product product)
        {
            var currentCartLine = LineCollection.Where(_ => _.Product.ProductID == product.ProductID).FirstOrDefault();
            LineCollection.Remove(currentCartLine);
        }

        public void Update(Product product, int quanlity)
        {
            var currentCartLine = LineCollection.Where(_ => _.Product.ProductID == product.ProductID).FirstOrDefault();

            if (currentCartLine != null)
            {
                currentCartLine.Quatity = quanlity;
            }
        }

        public decimal ComputerTotal()
        {
            return LineCollection
                .Sum(_ => (_.Quatity) * (_.Product.Price))
                .GetValueOrDefault(0);
        }

        public void Clear() {
            LineCollection.Clear();
        }
    }
}
