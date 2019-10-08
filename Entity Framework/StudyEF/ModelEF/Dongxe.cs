using System;
using System.Collections.Generic;

namespace ModelEF
{
    public partial class Dongxe
    {
        public Dongxe()
        {
            Dangkycungcap = new HashSet<Dangkycungcap>();
        }

        public string DongXe1 { get; set; }
        public string HangXe { get; set; }
        public int? SoChoNgoi { get; set; }

        public ICollection<Dangkycungcap> Dangkycungcap { get; set; }
    }
}
