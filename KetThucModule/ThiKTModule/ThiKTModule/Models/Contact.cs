using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManagement.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string Ho { get; set; }
        [Required]
        public string Ten { get; set; }
        [Required]
        public string SDT { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string DiaChi { get; set; }
        [Required]
        public int QueQuanId { get; set; }
        public QueQuan QueQuan { get; set; }
    }
}
