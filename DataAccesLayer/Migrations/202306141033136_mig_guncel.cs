namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_guncel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "CategoryName", c => c.String(maxLength: 50));
            DropColumn("dbo.Movies", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Name", c => c.String(maxLength: 50));
            DropColumn("dbo.Movies", "CategoryName");
        }
    }
}
