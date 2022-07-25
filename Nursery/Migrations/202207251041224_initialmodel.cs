namespace Nursery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Nurseries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SKU_NO = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        IsAvailable = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql:"GetDate()" ),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Nurseries", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Nurseries", new[] { "CategoryId" });
            DropTable("dbo.Nurseries");
            DropTable("dbo.Categories");
        }
    }
}
