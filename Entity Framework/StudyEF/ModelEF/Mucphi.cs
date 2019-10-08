using System;
using System.Collections.Generic;

namespace ModelEF
{
    public partial class Mucphi
    {
        public Mucphi()
        {
            Dangkycungcap = new HashSet<Dangkycungcap>();
        }

        public string MaMp { get; set; }
        public int? DonGia { get; set; }
        public string MoTa { get; set; }

        public ICollection<Dangkycungcap> Dangkycungcap { get; set; }
    }
}
