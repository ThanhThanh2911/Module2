using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH.Models
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name = "TÊN KHÁC HÀNG")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public string CustomerName { get; set; }

        [Display(Name = "TÀI KHOẢN")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public string Account { get; set; }

        [Display(Name = "MẬT KHẨU")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public string Password { get; set; }

        [Display(Name = "EMAIL")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public string Email { get; set; }

        [Display(Name = "ĐỊA CHỈ")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public string Address { get; set; }

        [Display(Name = "SỐ ĐIỆN THOẠI")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public string Phone { get; set; }

        [Display(Name = "GIỚI TÍNH")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public string Gender { get; set; }

        [Display(Name = "NGÀY SINH")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public DateTime BirthDay { get; set; }

        //public List<Bill> Bills { get; set; }
    }
}
