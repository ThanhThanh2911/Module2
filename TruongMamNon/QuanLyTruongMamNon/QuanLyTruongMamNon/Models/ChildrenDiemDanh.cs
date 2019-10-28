using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyTruongMamNon.Models
{
    public class ChildrenDiemDanh
    {
        public int ChildrenId { get; set; }
        public int DiemDanhId { get; set; }
        public int NgayId { get; set; }
        public bool Time { get; set; }

        public Children Children { get; set; }
        public DiemDanh DiemDanh { get; set; }
    }
}
