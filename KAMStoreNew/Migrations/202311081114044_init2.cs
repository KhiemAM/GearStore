﻿namespace KAMStoreNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Img", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Img", c => c.String(nullable: false));
        }
    }
}
