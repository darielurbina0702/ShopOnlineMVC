namespace ShopOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerIdToProductTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Customer_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Products", new[] { "Customer_Id" });
            AddColumn("dbo.Products", "Customer_Id1", c => c.String(maxLength: 128));
            AlterColumn("dbo.Products", "Customer_Id", c => c.String());
            CreateIndex("dbo.Products", "Customer_Id1");
            AddForeignKey("dbo.Products", "Customer_Id1", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Customer_Id1", "dbo.AspNetUsers");
            DropIndex("dbo.Products", new[] { "Customer_Id1" });
            AlterColumn("dbo.Products", "Customer_Id", c => c.String(maxLength: 128));
            DropColumn("dbo.Products", "Customer_Id1");
            CreateIndex("dbo.Products", "Customer_Id");
            AddForeignKey("dbo.Products", "Customer_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
