using SportsStore.Domain.Concrete;
using System.Collections.Generic;

namespace SportsStore.UI.Models
{
    public class HomeIndexViewModel
    {
        public int CurrentCategoryId { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}