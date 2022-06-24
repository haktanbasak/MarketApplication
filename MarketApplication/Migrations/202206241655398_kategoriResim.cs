namespace MarketApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kategoriResim : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategori", "Resim", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kategori", "Resim");
        }
    }
}
