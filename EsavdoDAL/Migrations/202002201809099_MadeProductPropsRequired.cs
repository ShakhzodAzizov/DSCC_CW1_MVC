﻿using System.Data.Entity.Migrations;
namespace EsavdoDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeProductPropsRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Category", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Category", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
        }
    }
}
