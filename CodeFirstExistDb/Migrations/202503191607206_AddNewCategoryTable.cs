﻿namespace CodeFirstExistDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewCategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewCategories");
        }
    }
}
