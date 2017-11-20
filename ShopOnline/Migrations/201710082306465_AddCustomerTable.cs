namespace ShopOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Customer_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "CustomerBalance", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.AspNetUsers", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Products", "Customer_Id");
            AddForeignKey("dbo.Products", "Customer_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Customer_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Products", new[] { "Customer_Id" });
            DropColumn("dbo.AspNetUsers", "Discriminator");
            DropColumn("dbo.AspNetUsers", "CustomerBalance");
            DropColumn("dbo.Products", "Customer_Id");
        }
    }
}
