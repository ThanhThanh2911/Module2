using System;
using System.Collections.Generic;
using System.Text;

namespace TruongDaiHocApp.Domain
{
    public class SinhVien
    {
        public int Id { get; set; }
        public string HoTenSV { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public List<GiaoVienMonHoc> GiaoVienMonHocs { get; set; }
        public int LopId { get; set; }
    }
}
