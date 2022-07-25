namespace Nursery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedUniqueIdInNurseries : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Nurseries", "SKU_NO", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Nurseries", new[] { "SKU_NO" });
        }
    }
}
