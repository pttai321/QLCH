using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuanLyCanHo.Models.Entities
{
    public partial class ModelQLCH : DbContext
    {
        public ModelQLCH()
            : base("name=ModelQLCH")
        {
        }

        public virtual DbSet<DatPhong> DatPhongs { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatPhong>()
                .Property(e => e.TenTaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<DatPhong>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.MaDichVu)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.MaLoai)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.DuongDanAnh)
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.TenPhong)
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.MaLoai)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TenTaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}