using System;
using System.Collections.Generic;

namespace ModelEF
{
    public partial class Lop
    {
        public Lop()
        {
            SinhVien = new HashSet<SinhVien>();
        }

        public int LopId { get; set; }
        public string TenLop { get; set; }
        public int? NganhId { get; set; }

        public Nganh Nganh { get; set; }
        public ICollection<SinhVien> SinhVien { get; set; }
    }
}
