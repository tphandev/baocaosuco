namespace BaoCaoSuCo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DonVis",
                c => new
                    {
                        MaDonVi = c.String(nullable: false, maxLength: 15, unicode: false),
                        TenDonVi = c.String(maxLength: 256),
                        NgayTao = c.DateTime(),
                        NguoiTao = c.String(maxLength: 256),
                        NgayCapNhat = c.DateTime(),
                        NguoiCapNhat = c.String(maxLength: 256),
                        xoa = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaDonVi);
            
            CreateTable(
                "dbo.SuCos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SoBaoCao = c.Int(nullable: false),
                        MaDonVi = c.String(nullable: false, maxLength: 15, unicode: false),
                        HoTenBenhNhan = c.String(nullable: false, maxLength: 256),
                        SoBenhAn = c.Int(nullable: false),
                        NgaySinh = c.DateTime(nullable: false),
                        GioiTinh = c.Int(nullable: false),
                        DoiTuong = c.Int(nullable: false),
                        LoaiBaoCao = c.Int(nullable: false),
                        NoiXayRa = c.String(nullable: false, maxLength: 500),
                        ViTri = c.String(nullable: false, maxLength: 500),
                        NgayXayRa = c.DateTime(nullable: false),
                        MoTo = c.String(nullable: false),
                        DeXuatGiaiPhap = c.String(nullable: false),
                        XuLiBanDau = c.String(nullable: false),
                        ThongBaoBacSi = c.Int(nullable: false),
                        ThongBaoNguoiNha = c.Int(nullable: false),
                        GhiNhanHoSo = c.Int(nullable: false),
                        ThongBaoBenhNhan = c.Int(nullable: false),
                        PhanLoaiBanDau = c.Int(nullable: false),
                        MucDoAnhHuong = c.Int(nullable: false),
                        HoTenNguoiBaoCao = c.String(maxLength: 256),
                        SoDienThoai = c.String(maxLength: 20),
                        Email = c.String(maxLength: 256),
                        ChucVu = c.Int(nullable: false),
                        ChucDanh = c.String(maxLength: 256),
                        Khac = c.String(maxLength: 256),
                        NguoiChungKien1 = c.String(maxLength: 256),
                        NguoiChungKien2 = c.String(maxLength: 256),
                        TrangThai = c.Int(nullable: false),
                        NgayTao = c.DateTime(),
                        NguoiTao = c.String(maxLength: 256),
                        NgayCapNhat = c.DateTime(),
                        NguoiCapNhat = c.String(maxLength: 256),
                        xoa = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DonVis", t => t.MaDonVi, cascadeDelete: true)
                .Index(t => t.MaDonVi);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SuCos", "MaDonVi", "dbo.DonVis");
            DropIndex("dbo.SuCos", new[] { "MaDonVi" });
            DropTable("dbo.SuCos");
            DropTable("dbo.DonVis");
        }
    }
}
