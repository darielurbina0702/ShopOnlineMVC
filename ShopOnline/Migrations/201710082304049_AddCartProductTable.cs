namespace ShopOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCartProductTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "OrderQty", c => c.Int());
            AddColumn("dbo.Products", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Discriminator");
            DropColumn("dbo.Products", "OrderQty");
        }
    }
}
