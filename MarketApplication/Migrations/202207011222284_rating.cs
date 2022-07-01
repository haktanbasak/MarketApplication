namespace MarketApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Yorum", "Rate", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Yorum", "Rate");
        }
    }
}
