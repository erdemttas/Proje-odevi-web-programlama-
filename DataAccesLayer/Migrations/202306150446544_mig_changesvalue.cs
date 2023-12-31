﻿namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_changesvalue : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ActressName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Movies", "DirectorName", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DirectorName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Movies", "ActressName", c => c.String(maxLength: 50));
        }
    }
}
