namespace MarketApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig321 : DbMigration
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
