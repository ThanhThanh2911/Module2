using System;
using System.Collections.Generic;

namespace ModelEF
{
    public partial class Nganh
    {
        public Nganh()
        {
            Lop = new HashSet<Lop>();
            MonHoc = new HashSet<MonHoc>();
        }

        public int NganhId { get; set; }
        public string TenNganh { get; set; }
        public int? KhoaId { get; set; }

        public Khoa Khoa { get; set; }
        public ICollection<Lop> Lop { get; set; }
        public ICollection<MonHoc> MonHoc { get; set; }
    }
}
