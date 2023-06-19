namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_kaldirma : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MovieName", c => c.String(maxLength: 50));
            AddColumn("dbo.Movies", "ActressName", c => c.String(maxLength: 50));
            AddColumn("dbo.Movies", "ActressSurname", c => c.String(maxLength: 50));
            AddColumn("dbo.Movies", "DirectorName", c => c.String());
            AddColumn("dbo.Movies", "DirectorSurname", c => c.String(maxLength: 50));
            DropTable("dbo.Actresses");
            DropTable("dbo.Categories");
            DropTable("dbo.Directors");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        DirectorID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Surname = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.DirectorID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Actresses",
                c => new
                    {
                        ActressID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Surname = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ActressID);
            
            DropColumn("dbo.Movies", "DirectorSurname");
            DropColumn("dbo.Movies", "DirectorName");
            DropColumn("dbo.Movies", "ActressSurname");
            DropColumn("dbo.Movies", "ActressName");
            DropColumn("dbo.Movies", "MovieName");
        }
    }
}
