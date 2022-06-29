namespace MarketApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class satici_ekleme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Satici",
                c => new
                    {
                        SaticiId = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(),
                        Sifre = c.String(),
                        Eposta = c.String(),
                        Telefon = c.String(),
                        MagazaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SaticiId)
                .ForeignKey("dbo.Magaza", t => t.MagazaId, cascadeDelete: true)
                .Index(t => t.MagazaId);
            
            AddColumn("dbo.Siparis", "SaticiId", c => c.Int(nullable: false));
            CreateIndex("dbo.Siparis", "SaticiId");
            AddForeignKey("dbo.Siparis", "SaticiId", "dbo.Satici", "SaticiId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Siparis", "SaticiId", "dbo.Satici");
            DropForeignKey("dbo.Satici", "MagazaId", "dbo.Magaza");
            DropIndex("dbo.Siparis", new[] { "SaticiId" });
            DropIndex("dbo.Satici", new[] { "MagazaId" });
            DropColumn("dbo.Siparis", "SaticiId");
            DropTable("dbo.Satici");
        }
    }
}
