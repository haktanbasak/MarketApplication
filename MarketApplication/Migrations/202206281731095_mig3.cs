namespace MarketApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Siparis", "UrunId", "dbo.Urun");
            DropIndex("dbo.Siparis", new[] { "UrunId" });
            AddColumn("dbo.Sepet", "SiparisId", c => c.Int());
            CreateIndex("dbo.Sepet", "SiparisId");
            AddForeignKey("dbo.Sepet", "SiparisId", "dbo.Siparis", "SiparisId");
            DropColumn("dbo.Siparis", "UrunId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Siparis", "UrunId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Sepet", "SiparisId", "dbo.Siparis");
            DropIndex("dbo.Sepet", new[] { "SiparisId" });
            DropColumn("dbo.Sepet", "SiparisId");
            CreateIndex("dbo.Siparis", "UrunId");
            AddForeignKey("dbo.Siparis", "UrunId", "dbo.Urun", "UrunId", cascadeDelete: true);
        }
    }
}
