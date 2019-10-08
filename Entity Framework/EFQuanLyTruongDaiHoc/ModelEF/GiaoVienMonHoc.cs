using System;
using System.Collections.Generic;

namespace ModelEF
{
    public partial class GiaoVienMonHoc
    {
        public GiaoVienMonHoc()
        {
            SinhVien = new HashSet<SinhVien>();
        }

        public int MaGvMh { get; set; }
        public int? MaGv { get; set; }
        public int? MonHocId { get; set; }

        public GiaoVien MaGvNavigation { get; set; }
        public MonHoc MonHoc { get; set; }
        public ICollection<SinhVien> SinhVien { get; set; }
    }
}
