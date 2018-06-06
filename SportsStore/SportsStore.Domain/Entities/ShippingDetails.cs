
using System.ComponentModel.DataAnnotations;

namespace SportsStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Vui Long Nhap Ten")]
        [Display(Name = "Ho Ten")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Vui Long Email")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage ="Email khong dung dinh dang")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui Long Dia Chi")]
        [Display(Name = "Dia Chi")]
        public string Address { get; set; }

        public string Note { get; set; }
    }
}
