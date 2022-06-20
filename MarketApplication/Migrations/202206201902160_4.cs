namespace MarketApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sepet",
                c => new
                    {
                        SepetId = c.Int(nullable: false, identity: true),
                        Adet = c.Int(nullable: false),
                        isAktif = c.Boolean(nullable: false),
                        SepetTutar = c.Double(nullable: false),
                        UrunId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SepetId)
                .ForeignKey("dbo.Urun", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.UrunId);
            
            DropColumn("dbo.Siparis", "Adet");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Siparis", "Adet", c => c.Int(nullable: false));
            DropForeignKey("dbo.Sepet", "UrunId", "dbo.Urun");
            DropIndex("dbo.Sepet", new[] { "UrunId" });
            DropTable("dbo.Sepet");
        }
    }
}
