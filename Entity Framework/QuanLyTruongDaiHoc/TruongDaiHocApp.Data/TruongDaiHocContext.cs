using System;
using TruongDaiHocApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace TruongDaiHocApp.Data
{
    public class TruongDaiHocContext : DbContext
    {
        public DbSet<GiaoVien> GiaoViens { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<GiaoVienMonHoc> GiaoVienMonHocs { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = ADMIN\\SQLEXPRESS; Database=TruongDaiHocAppDataCore; Trusted_Connection = True; ");
        }
    }
}
