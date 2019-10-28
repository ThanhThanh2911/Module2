using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        [Display(Name = "TÊN NHÀ CUNG CẤP")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public string SupplierName { get; set; }
        [Display(Name = "SỐ ĐIỆN THOẠI")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public string Phone { get; set; }
        [Display(Name = "ĐỊA CHỈ")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public string Address { get; set; }
        [Display(Name = "EMAIL")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public string Email { get; set; }

        public List<Product> Products { get; set; }
    }
}
