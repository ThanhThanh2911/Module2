using System;
using System.Collections.Generic;

namespace ModelEF
{
    public partial class Dangkycungcap
    {
        public string MaDkcc { get; set; }
        public string MaNhaCc { get; set; }
        public string MaLoaiDv { get; set; }
        public string DongXe { get; set; }
        public string MaMp { get; set; }
        public DateTime? NgayBatDauCungCap { get; set; }
        public DateTime? NgayKetThucCungCap { get; set; }
        public int? SoLuongXeDangKy { get; set; }

        public Dongxe DongXeNavigation { get; set; }
        public Loaidichvu MaLoaiDvNavigation { get; set; }
        public Mucphi MaMpNavigation { get; set; }
        public Nhacungcap MaNhaCcNavigation { get; set; }
    }
}
