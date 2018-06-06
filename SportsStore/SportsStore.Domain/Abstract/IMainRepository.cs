using SportsStore.Domain.Concrete;
using System.Linq;

namespace SportsStore.Domain.Abstract
{
    public interface IMainRepository
    {
        IQueryable<Product> Products { get; }
        IQueryable<Category> Categories { get; }
        IQueryable<ProductItem> ProductItems { get; }
        IQueryable<Gender> Genders { get; }
        IQueryable<Status> Statuses { get; } 
        IQueryable<Product> HotProducts { get; }
        IQueryable<Wallpaper> HotWallpapers { get; }
    }
}
