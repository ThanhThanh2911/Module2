using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ModelEF
{
    public partial class QUANLYNHACUNGCAPContext : DbContext
    {
        public QUANLYNHACUNGCAPContext()
        {
        }

        public QUANLYNHACUNGCAPContext(DbContextOptions<QUANLYNHACUNGCAPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dangkycungcap> Dangkycungcap { get; set; }
        public virtual DbSet<Dongxe> Dongxe { get; set; }
        public virtual DbSet<Loaidichvu> Loaidichvu { get; set; }
        public virtual DbSet<Mucphi> Mucphi { get; set; }
        public virtual DbSet<Nhacungcap> Nhacungcap { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=QUANLYNHACUNGCAP;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dangkycungcap>(entity =>
            {
                entity.HasKey(e => e.MaDkcc);

                entity.ToTable("DANGKYCUNGCAP");

                entity.Property(e => e.MaDkcc)
                    .HasColumnName("MaDKCC")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DongXe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaLoaiDv)
                    .HasColumnName("MaLoaiDV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaMp)
                    .HasColumnName("MaMP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaNhaCc)
                    .HasColumnName("MaNhaCC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgayBatDauCungCap).HasColumnType("date");

                entity.Property(e => e.NgayKetThucCungCap).HasColumnType("date");

                entity.HasOne(d => d.DongXeNavigation)
                    .WithMany(p => p.Dangkycungcap)
                    .HasForeignKey(d => d.DongXe)
                    .HasConstraintName("fk_DX");

                entity.HasOne(d => d.MaLoaiDvNavigation)
                    .WithMany(p => p.Dangkycungcap)
                    .HasForeignKey(d => d.MaLoaiDv)
                    .HasConstraintName("fk_MLDV");

                entity.HasOne(d => d.MaMpNavigation)
                    .WithMany(p => p.Dangkycungcap)
                    .HasForeignKey(d => d.MaMp)
                    .HasConstraintName("fk_MMP");

                entity.HasOne(d => d.MaNhaCcNavigation)
                    .WithMany(p => p.Dangkycungcap)
                    .HasForeignKey(d => d.MaNhaCc)
                    .HasConstraintName("fk_MNCC");
            });

            modelBuilder.Entity<Dongxe>(entity =>
            {
                entity.HasKey(e => e.DongXe1);

                entity.ToTable("DONGXE");

                entity.Property(e => e.DongXe1)
                    .HasColumnName("DongXe")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.HangXe)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Loaidichvu>(entity =>
            {
                entity.HasKey(e => e.MaLoaiDv);

                entity.ToTable("LOAIDICHVU");

                entity.Property(e => e.MaLoaiDv)
                    .HasColumnName("MaLoaiDV")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.TenLoaiDv)
                    .HasColumnName("TenLoaiDV")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mucphi>(entity =>
            {
                entity.HasKey(e => e.MaMp);

                entity.ToTable("MUCPHI");

                entity.Property(e => e.MaMp)
                    .HasColumnName("MaMP")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.MoTa)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nhacungcap>(entity =>
            {
                entity.HasKey(e => e.MaNhaCc);

                entity.ToTable("NHACUNGCAP");

                entity.Property(e => e.MaNhaCc)
                    .HasColumnName("MaNhaCC")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoDt)
                    .HasColumnName("SoDT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenNhaCc)
                    .HasColumnName("TenNhaCC")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
