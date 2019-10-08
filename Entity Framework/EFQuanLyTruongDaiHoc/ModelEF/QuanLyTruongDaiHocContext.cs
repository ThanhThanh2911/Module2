using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ModelEF
{
    public partial class QuanLyTruongDaiHocContext : DbContext
    {
        public QuanLyTruongDaiHocContext()
        {
        }

        public QuanLyTruongDaiHocContext(DbContextOptions<QuanLyTruongDaiHocContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GiaoVien> GiaoVien { get; set; }
        public virtual DbSet<GiaoVienMonHoc> GiaoVienMonHoc { get; set; }
        public virtual DbSet<Khoa> Khoa { get; set; }
        public virtual DbSet<Lop> Lop { get; set; }
        public virtual DbSet<MonHoc> MonHoc { get; set; }
        public virtual DbSet<Nganh> Nganh { get; set; }
        public virtual DbSet<SinhVien> SinhVien { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=QuanLyTruongDaiHoc;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GiaoVien>(entity =>
            {
                entity.HasKey(e => e.MaGv);

                entity.Property(e => e.MaGv).HasColumnName("MaGV");

                entity.Property(e => e.GioiTinh)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.HoTenGv)
                    .HasColumnName("HoTenGV")
                    .HasMaxLength(20);

                entity.Property(e => e.KhoaId).HasColumnName("KhoaID");

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.HasOne(d => d.Khoa)
                    .WithMany(p => p.GiaoVien)
                    .HasForeignKey(d => d.KhoaId)
                    .HasConstraintName("fk_KHID");
            });

            modelBuilder.Entity<GiaoVienMonHoc>(entity =>
            {
                entity.HasKey(e => e.MaGvMh);

                entity.ToTable("GiaoVien_MonHoc");

                entity.Property(e => e.MaGvMh).HasColumnName("MaGV_MH");

                entity.Property(e => e.MaGv).HasColumnName("MaGV");

                entity.Property(e => e.MonHocId).HasColumnName("MonHocID");

                entity.HasOne(d => d.MaGvNavigation)
                    .WithMany(p => p.GiaoVienMonHoc)
                    .HasForeignKey(d => d.MaGv)
                    .HasConstraintName("fk_GV");

                entity.HasOne(d => d.MonHoc)
                    .WithMany(p => p.GiaoVienMonHoc)
                    .HasForeignKey(d => d.MonHocId)
                    .HasConstraintName("fk_MH");
            });

            modelBuilder.Entity<Khoa>(entity =>
            {
                entity.Property(e => e.KhoaId).HasColumnName("KhoaID");

                entity.Property(e => e.TenKhoa).HasMaxLength(20);
            });

            modelBuilder.Entity<Lop>(entity =>
            {
                entity.Property(e => e.LopId).HasColumnName("LopID");

                entity.Property(e => e.NganhId).HasColumnName("NganhID");

                entity.Property(e => e.TenLop).HasMaxLength(20);

                entity.HasOne(d => d.Nganh)
                    .WithMany(p => p.Lop)
                    .HasForeignKey(d => d.NganhId)
                    .HasConstraintName("fk_NID");
            });

            modelBuilder.Entity<MonHoc>(entity =>
            {
                entity.Property(e => e.MonHocId).HasColumnName("MonHocID");

                entity.Property(e => e.NganhId).HasColumnName("NganhID");

                entity.Property(e => e.TenMonHoc).HasMaxLength(20);

                entity.HasOne(d => d.Nganh)
                    .WithMany(p => p.MonHoc)
                    .HasForeignKey(d => d.NganhId)
                    .HasConstraintName("fk_NGID");
            });

            modelBuilder.Entity<Nganh>(entity =>
            {
                entity.Property(e => e.NganhId).HasColumnName("NganhID");

                entity.Property(e => e.KhoaId).HasColumnName("KhoaID");

                entity.Property(e => e.TenNganh).HasMaxLength(20);

                entity.HasOne(d => d.Khoa)
                    .WithMany(p => p.Nganh)
                    .HasForeignKey(d => d.KhoaId)
                    .HasConstraintName("fk_KID");
            });

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.HasKey(e => e.MaSv);

                entity.Property(e => e.MaSv).HasColumnName("MaSV");

                entity.Property(e => e.GioiTinh)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.HoTenSv)
                    .HasColumnName("HoTenSV")
                    .HasMaxLength(20);

                entity.Property(e => e.LopId).HasColumnName("LopID");

                entity.Property(e => e.MaGvMh).HasColumnName("MaGV_MH");

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.HasOne(d => d.Lop)
                    .WithMany(p => p.SinhVien)
                    .HasForeignKey(d => d.LopId)
                    .HasConstraintName("fk_LOP");

                entity.HasOne(d => d.MaGvMhNavigation)
                    .WithMany(p => p.SinhVien)
                    .HasForeignKey(d => d.MaGvMh)
                    .HasConstraintName("fk_GVMH");
            });
        }
    }
}
