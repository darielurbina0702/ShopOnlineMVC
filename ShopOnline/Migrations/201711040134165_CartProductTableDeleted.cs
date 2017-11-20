namespace ShopOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CartProductTableDeleted : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "OrderQty", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Products", "OrderQty", c => c.Int());
        }
    }
}
