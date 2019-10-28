using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH.Models
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        [Display(Name = "THANH TOÁN")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public int Paid { get; set; }
        [Display(Name = "TRẠNG THÁI ĐƠN HÀNG")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public int OrderStatus { get; set; }
        [Display(Name = "NGÀY ĐẶT")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public DateTime OrderDate { get; set; }
        [Display(Name = "NGÀY GIAO")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public DateTime DeliveryDate { get; set; }

        [Display(Name = "MÃ KHÁCH HÀNG")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")]
        public int CustomerId { get; set; }
        public Customers Customers { get; set; }

    }
}
