using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopShoes.Web.Models.Product
{
    public class SaveProduct
    {
        //[Key]
        public int ID { get; set; }
        //[Required(ErrorMessage ="Vui lòng nhập tên sản phẩm.")]
        public string ProductName { get; set; }
        //[Required(ErrorMessage = "Vui lòng nhập nhãn hiệu cho sản phẩm.")]
        public int BrandID { get; set; }
        //[Required(ErrorMessage = "Vui lòng nhập loại sản phẩm.")]
        public int CategoryID { get; set; }
        //[Required(ErrorMessage = "Vui lòng nhập giá cho sản phẩm.")]
        public decimal Price { get; set; }
    }
}
