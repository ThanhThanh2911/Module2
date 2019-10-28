using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyTruongMamNon.Models
{
    public class DiemDanh
    {
        public int Id { get; set; }
        public bool Morning { get; set; }
        public bool Afternoon { get; set; }

        public List<ChildrenDiemDanh> Childrens { get; set; }
    }
}
