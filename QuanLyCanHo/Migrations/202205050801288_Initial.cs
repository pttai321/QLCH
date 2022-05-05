namespace QuanLyCanHo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DatPhong",
                c => new
                    {
                        MaDatPhong = c.Int(nullable: false),
                        TenTaiKhoan = c.String(maxLength: 20, unicode: false),
                        MaPhong = c.String(maxLength: 10, unicode: false),
                        NgayDat = c.DateTime(storeType: "date"),
                        NgayDen = c.DateTime(storeType: "date"),
                        NgayTra = c.DateTime(storeType: "date"),
                        DichVu = c.String(maxLength: 100),
                        ThanhTien = c.Int(),
                    })
                .PrimaryKey(t => t.MaDatPhong)
                .ForeignKey("dbo.Phong", t => t.MaPhong)
                .ForeignKey("dbo.TaiKhoan", t => t.TenTaiKhoan)
                .Index(t => t.TenTaiKhoan)
                .Index(t => t.MaPhong);
            
            CreateTable(
                "dbo.Phong",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenPhong = c.String(nullable: false, maxLength: 10, unicode: false),
                        MaLoai = c.String(maxLength: 10, unicode: false),
                        DienTich = c.Int(nullable: false),
                        GiaThue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhong)
                .ForeignKey("dbo.LoaiPhong", t => t.MaLoai)
                .Index(t => t.MaLoai);
            
            CreateTable(
                "dbo.LoaiPhong",
                c => new
                    {
                        MaLoai = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenLoai = c.String(nullable: false, maxLength: 30),
                        GhiChu = c.String(nullable: false, maxLength: 250),
                        DuongDanAnh = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.MaLoai);
            
            CreateTable(
                "dbo.TaiKhoan",
                c => new
                    {
                        TenTaiKhoan = c.String(nullable: false, maxLength: 20, unicode: false),
                        MatKhau = c.String(nullable: false, maxLength: 20, unicode: false),
                        HoTen = c.String(nullable: false, maxLength: 30),
                        SoDienThoai = c.String(nullable: false, maxLength: 20, unicode: false),
                        Email = c.String(nullable: false, maxLength: 35, unicode: false),
                        LaAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TenTaiKhoan);
            
            CreateTable(
                "dbo.DichVus",
                c => new
                    {
                        MaDichVu = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenDichVu = c.String(nullable: false, maxLength: 20),
                        GiaDichVu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaDichVu);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DatPhong", "TenTaiKhoan", "dbo.TaiKhoan");
            DropForeignKey("dbo.Phong", "MaLoai", "dbo.LoaiPhong");
            DropForeignKey("dbo.DatPhong", "MaPhong", "dbo.Phong");
            DropIndex("dbo.Phong", new[] { "MaLoai" });
            DropIndex("dbo.DatPhong", new[] { "MaPhong" });
            DropIndex("dbo.DatPhong", new[] { "TenTaiKhoan" });
            DropTable("dbo.DichVus");
            DropTable("dbo.TaiKhoan");
            DropTable("dbo.LoaiPhong");
            DropTable("dbo.Phong");
            DropTable("dbo.DatPhong");
        }
    }
}
