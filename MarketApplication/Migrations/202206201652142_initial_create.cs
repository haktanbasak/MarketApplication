namespace MarketApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategori",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.KategoriId);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        UrunId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Fiyat = c.Double(nullable: false),
                        Fotograf = c.String(),
                        Icindekiler = c.String(),
                        KategoriId = c.Int(nullable: false),
                        MagazaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UrunId)
                .ForeignKey("dbo.Kategori", t => t.KategoriId, cascadeDelete: true)
                .ForeignKey("dbo.Magaza", t => t.MagazaId, cascadeDelete: true)
                .Index(t => t.KategoriId)
                .Index(t => t.MagazaId);
            
            CreateTable(
                "dbo.Magaza",
                c => new
                    {
                        MagazaId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        MinimumFiyat = c.Double(nullable: false),
                        Konum = c.String(),
                        MagazaKategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MagazaId)
                .ForeignKey("dbo.MagazaKategori", t => t.MagazaKategoriId, cascadeDelete: true)
                .Index(t => t.MagazaKategoriId);
            
            CreateTable(
                "dbo.MagazaKategori",
                c => new
                    {
                        MagazaKategoriId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.MagazaKategoriId);
            
            CreateTable(
                "dbo.Yorum",
                c => new
                    {
                        YorumId = c.Int(nullable: false, identity: true),
                        YorumIcerik = c.String(),
                        UrunId = c.Int(),
                        MagazaId = c.Int(),
                        KullaniciId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.YorumId)
                .ForeignKey("dbo.Kullanici", t => t.KullaniciId, cascadeDelete: true)
                .ForeignKey("dbo.Magaza", t => t.MagazaId)
                .ForeignKey("dbo.Urun", t => t.UrunId)
                .Index(t => t.UrunId)
                .Index(t => t.MagazaId)
                .Index(t => t.KullaniciId);
            
            CreateTable(
                "dbo.Kullanici",
                c => new
                    {
                        KullaniciId = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(),
                        Sifre = c.String(),
                        Eposta = c.String(),
                        Telefon = c.String(),
                        Adres = c.String(),
                    })
                .PrimaryKey(t => t.KullaniciId);
            
            CreateTable(
                "dbo.Siparis",
                c => new
                    {
                        SiparisId = c.Int(nullable: false, identity: true),
                        Tutar = c.Double(nullable: false),
                        Adres = c.String(),
                        UrunId = c.Int(nullable: false),
                        KullaniciId = c.Int(nullable: false),
                        SiparisStatuId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SiparisId)
                .ForeignKey("dbo.Kullanici", t => t.KullaniciId, cascadeDelete: true)
                .ForeignKey("dbo.SiparisStatu", t => t.SiparisStatuId, cascadeDelete: true)
                .ForeignKey("dbo.Urun", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.UrunId)
                .Index(t => t.KullaniciId)
                .Index(t => t.SiparisStatuId);
            
            CreateTable(
                "dbo.SiparisStatu",
                c => new
                    {
                        SiparisStatuId = c.Int(nullable: false, identity: true),
                        Statu = c.String(),
                    })
                .PrimaryKey(t => t.SiparisStatuId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Yorum", "UrunId", "dbo.Urun");
            DropForeignKey("dbo.Yorum", "MagazaId", "dbo.Magaza");
            DropForeignKey("dbo.Yorum", "KullaniciId", "dbo.Kullanici");
            DropForeignKey("dbo.Siparis", "UrunId", "dbo.Urun");
            DropForeignKey("dbo.Siparis", "SiparisStatuId", "dbo.SiparisStatu");
            DropForeignKey("dbo.Siparis", "KullaniciId", "dbo.Kullanici");
            DropForeignKey("dbo.Urun", "MagazaId", "dbo.Magaza");
            DropForeignKey("dbo.Magaza", "MagazaKategoriId", "dbo.MagazaKategori");
            DropForeignKey("dbo.Urun", "KategoriId", "dbo.Kategori");
            DropIndex("dbo.Siparis", new[] { "SiparisStatuId" });
            DropIndex("dbo.Siparis", new[] { "KullaniciId" });
            DropIndex("dbo.Siparis", new[] { "UrunId" });
            DropIndex("dbo.Yorum", new[] { "KullaniciId" });
            DropIndex("dbo.Yorum", new[] { "MagazaId" });
            DropIndex("dbo.Yorum", new[] { "UrunId" });
            DropIndex("dbo.Magaza", new[] { "MagazaKategoriId" });
            DropIndex("dbo.Urun", new[] { "MagazaId" });
            DropIndex("dbo.Urun", new[] { "KategoriId" });
            DropTable("dbo.SiparisStatu");
            DropTable("dbo.Siparis");
            DropTable("dbo.Kullanici");
            DropTable("dbo.Yorum");
            DropTable("dbo.MagazaKategori");
            DropTable("dbo.Magaza");
            DropTable("dbo.Urun");
            DropTable("dbo.Kategori");
        }
    }
}
