using System;
using System.Collections.Generic;

namespace ModelEF
{
    public partial class MonHoc
    {
        public MonHoc()
        {
            GiaoVienMonHoc = new HashSet<GiaoVienMonHoc>();
        }

        public int MonHocId { get; set; }
        public string TenMonHoc { get; set; }
        public int? NganhId { get; set; }

        public Nganh Nganh { get; set; }
        public ICollection<GiaoVienMonHoc> GiaoVienMonHoc { get; set; }
    }
}
