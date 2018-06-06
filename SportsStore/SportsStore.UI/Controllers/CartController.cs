using SportsStore.Domain.Abstract;
using SportsStore.Domain.Concrete;
using SportsStore.Domain.Entities;
using System.Linq;
using System.Web.Mvc;

namespace SportsStore.UI.Controllers
{
    public class CartController : Controller
    {
        private IMainRepository _mainRepository;
        private IOrderProcessor _orderProcessor;

        public CartController()
        {
            _mainRepository = new MainRepository();
            _orderProcessor = new EmailOrderProcessor();
        }

        // GET: Cart
        public ViewResult Index()
        {
            var cart = Session["cart"] as Cart;

            if(cart == null)
            {
                cart = new Cart();
            }

            return View(cart);
        }

        [HttpPost]
        public RedirectToRouteResult AddToCart(int productId, int quantity)
        {
            var product = _mainRepository
                .Products
                .FirstOrDefault(_ => _.ProductID == productId);

            if( product != null ){
                var cart = Session["cart"] as Cart;
                if (cart == null)
                {
                    cart = new Cart();
                    //save
                    Session["cart"] = cart;
                }
                cart.Add(product, 1);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToRouteResult RemoveFromCart(int productId)
        {
            var product = _mainRepository
                .Products
                .FirstOrDefault(x => x.ProductID == productId);
            if (product != null)
            {
                Cart cart = Session["cart"] as Cart;
                cart.Remove(product);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToRouteResult UpdateCart(
                int productId,
                int quantity)
        {
            var product = _mainRepository
                .Products
                .FirstOrDefault(x => x.ProductID == productId);
            if (product != null)
            {
                Cart cart = Session["cart"] as Cart;
                cart.Update(product, quantity);
            }
            return RedirectToAction("Index");
        }

        public ViewResult Checkout()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Checkout(ShippingDetails model)
        {
            Cart cart = Session["cart"] as Cart;
            if( cart == null || cart.LineCollection.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty!");
            }

            if (ModelState.IsValid)
            {
                // process
                _orderProcessor.ProcessorOrder(model, cart);
                // empty cart
                cart.Clear();
                Session["cart"] = null;

                // redirect to home
                return RedirectToAction("Complete");
            }
            return View(model);
        }

        public ViewResult Complete()
        {
            return View();
        }
    }
}