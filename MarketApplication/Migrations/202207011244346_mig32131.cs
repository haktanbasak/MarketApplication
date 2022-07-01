namespace MarketApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig32131 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Magaza", "Rate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Magaza", "Rate", c => c.Double());
        }
    }
}
