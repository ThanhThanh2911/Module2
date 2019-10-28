using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyTruongMamNon.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Children> Childrens { get; set; }
        public DbSet<PhuHuynh> PhuHuynhs { get; set; }
        public DbSet<DiemDanh> DiemDanhs { get; set; }
        public DbSet<ChildrenDiemDanh> ChildrenDiemDanhs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChildrenDiemDanh>().HasKey(children => new { children.ChildrenId, children.DiemDanhId, children.NgayId });
        }
    }
}
