using System;
using System.Collections.Generic;

namespace ModelEF
{
    public partial class Nhacungcap
    {
        public Nhacungcap()
        {
            Dangkycungcap = new HashSet<Dangkycungcap>();
        }

        public string MaNhaCc { get; set; }
        public string TenNhaCc { get; set; }
        public string DiaChi { get; set; }
        public string SoDt { get; set; }
        public int? MaSoThue { get; set; }

        public ICollection<Dangkycungcap> Dangkycungcap { get; set; }
    }
}
