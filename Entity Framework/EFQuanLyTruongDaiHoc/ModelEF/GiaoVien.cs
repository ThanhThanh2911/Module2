using System;
using System.Collections.Generic;

namespace ModelEF
{
    public partial class GiaoVien
    {
        public GiaoVien()
        {
            GiaoVienMonHoc = new HashSet<GiaoVienMonHoc>();
        }

        public int MaGv { get; set; }
        public string HoTenGv { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int? KhoaId { get; set; }

        public Khoa Khoa { get; set; }
        public ICollection<GiaoVienMonHoc> GiaoVienMonHoc { get; set; }
    }
}
