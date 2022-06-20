namespace MarketApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urun", "Aciklama", c => c.String());
            AddColumn("dbo.Siparis", "Adet", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Siparis", "Adet");
            DropColumn("dbo.Urun", "Aciklama");
        }
    }
}
