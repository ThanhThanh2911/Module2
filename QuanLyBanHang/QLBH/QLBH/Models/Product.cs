using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name = "TÊN SẢN PHẨM")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public string ProductName { get; set; }
        [Display(Name = "GIÁ TIỀN")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public int Price { get; set; }
        [Display(Name = "MÔ TẢ SẢN PHẨM")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public string Description { get; set; }
        [Display(Name = "ẢNH SẢN PHẨM")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public string ImgProduct { get; set; }
        [Display(Name = "NGÀY SẢN XUẤT")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public DateTime StartDay { get; set; }
        [Display(Name = "NGÀY HẾT HẠN")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public DateTime EndDay { get; set; }
        [Display(Name = "ĐỊA CHỈ SẢN XUẤT")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public string ProductionAddress { get; set; }

        //[Display(Name = "MÃ NHÀ CHI NHÁNH")]
        //public int SupplierId { get; set; }
        //public Supplier Supplier { get; set; }
        [Display(Name = "MÃ NHÀ SẢN XUẤT")]
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

        [Display(Name = "KIỂU SẢN PHẨM")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public bool NewProduct { get; set; }

    }
}
