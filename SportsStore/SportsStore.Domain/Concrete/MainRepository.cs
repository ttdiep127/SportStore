using SportsStore.Domain.Abstract;
using SportsStore.Domain.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Domain.Concrete
{
    public class MainRepository : IMainRepository
    {
        public ShoeStoreEntities _context;
        

        public MainRepository()
        {
            _context = new ShoeStoreEntities();
        }

        public IQueryable<Product> Products => _context.Products;

        public IQueryable<Category> Categories => _context.Categories;

        public IQueryable<ProductItem> ProductItems =>  _context.ProductItems;

        public IQueryable<Gender> Genders => _context.Genders;

        public IQueryable<Status> Statuses => _context.Statuses;

        public IQueryable<Product> HotProducts => _context.Products.Where(_ => _.StatusID == (int)StatusProducts.Hot);

        public IQueryable<Wallpaper> HotWallpapers => _context.Wallpapers.Where(_ => _.Display == true);
     }
}
