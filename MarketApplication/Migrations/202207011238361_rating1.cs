namespace MarketApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rating1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Magaza", "Rate", c => c.Double());
            DropColumn("dbo.Yorum", "Rate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Yorum", "Rate", c => c.Double());
            DropColumn("dbo.Magaza", "Rate");
        }
    }
}
