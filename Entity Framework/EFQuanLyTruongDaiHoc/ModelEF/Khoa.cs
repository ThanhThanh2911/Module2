using System;
using System.Collections.Generic;

namespace ModelEF
{
    public partial class Khoa
    {
        public Khoa()
        {
            GiaoVien = new HashSet<GiaoVien>();
            Nganh = new HashSet<Nganh>();
        }

        public int KhoaId { get; set; }
        public string TenKhoa { get; set; }

        public ICollection<GiaoVien> GiaoVien { get; set; }
        public ICollection<Nganh> Nganh { get; set; }
    }
}
