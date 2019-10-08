using System;
using System.Collections.Generic;
using System.Text;

namespace TruongDaiHocApp.Domain
{
    public class GiaoVienMonHoc
    {
        public int Id { get; set; }
        public int GiaoVienId { get; set; }
        public int MonHocId { get; set; }
        public MonHoc MonHoc { get; set; }
        public GiaoVien GiaoVien { get; set; }
    }
}
