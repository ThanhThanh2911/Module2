using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH.Models
{
    public class ProductType
    {
        [Key]
        public int ProductTypeId { get; set; }
        [Display(Name = "LOẠI SẢN PHẨM")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public string ProductTypeName { get; set; }

        public List<Product> Products { get; set; }
    }
}
