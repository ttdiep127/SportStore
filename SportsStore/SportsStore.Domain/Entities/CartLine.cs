using SportsStore.Domain.Concrete;

namespace SportsStore.Domain.Entities
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quatity { get; set; }
    }
}
