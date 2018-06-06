using SportsStore.Domain.Abstract;
using SportsStore.Domain.Concrete;
using SportsStore.UI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SportsStore.UI.Controllers
{
    public class HomeController : Controller
    {
        private IMainRepository _mainRepository;

        public HomeController()
        {
            _mainRepository = new MainRepository();
        }
        // GET: Home
        public ActionResult Index(int categoryId = 0, int page = 1)
        {
            HomeIndexViewModel model = new HomeIndexViewModel();

            model.Products = _mainRepository.HotProducts
                .Where(_ => _.CategoryID == categoryId || categoryId == 0)
                .OrderByDescending(x => x.ProductID)
                .Skip((page - 1) * 4)
                .Take(4);
            model.PagingInfo = new PagingInfo()
            {
                CurrentPage = page,
                ItemsPerPage = 4,
                TotalItems = _mainRepository
                .Products
                .Where(_ => categoryId == 0 || _.CategoryID == categoryId)
                .Count()
            };

            model.CurrentCategoryId = categoryId;
            return View(model);
        }

        public PartialViewResult SideMenuPartial()
        {
            var model = _mainRepository.Categories;

            return PartialView(model);
        }

        public PartialViewResult CarouslePartial()
        {
            var model = _mainRepository.HotWallpapers;            
            return PartialView(model);
        }

        public ActionResult Product()
        {
            var products = _mainRepository.Products;
            return View(products);
        }
    }
}