using System;
using System.Collections.Generic;

namespace ModelEF
{
    public partial class Loaidichvu
    {
        public Loaidichvu()
        {
            Dangkycungcap = new HashSet<Dangkycungcap>();
        }

        public string MaLoaiDv { get; set; }
        public string TenLoaiDv { get; set; }

        public ICollection<Dangkycungcap> Dangkycungcap { get; set; }
    }
}
