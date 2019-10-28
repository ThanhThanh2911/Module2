using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyTruongMamNon.Models
{
    public class Children
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime NgaySinh { get; set; }

        public int PhuHuynhId { get; set; }
        public PhuHuynh PhuHuynh { get; set; }

        public List<ChildrenDiemDanh> DiemDanhs { get; set; }
    }
}
