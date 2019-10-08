using System;
using System.Collections.Generic;

namespace ModelEF
{
    public partial class SinhVien
    {
        public int MaSv { get; set; }
        public string HoTenSv { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int? MaGvMh { get; set; }
        public int? LopId { get; set; }

        public Lop Lop { get; set; }
        public GiaoVienMonHoc MaGvMhNavigation { get; set; }
    }
}
