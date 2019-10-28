using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyTruongMamNon.Models
{
    public class PhuHuynh
    {
        public int Id { get; set; }
        public string TenPhuHuynh { get; set; }
        public string Email { get; set; }

        public Children Children { get; set; }
    }
}
