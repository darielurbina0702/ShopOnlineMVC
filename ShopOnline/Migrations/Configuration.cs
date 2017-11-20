namespace ShopOnline.Migrations
{
    using ShopOnline.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopOnline.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
       
        protected override void Seed(ShopOnline.Models.ApplicationDbContext context)
        {
           
            //Products
            //context.Products.AddOrUpdate(
              //  p => p.Name,
              // new Product() {  Name = "Nike Shoes", Description = "Best seller 2017", Category = "Clothes", Price = 70.99m, StockQty = 34, Discount = 0 },
              //  new Product() {  Name = "Dell Laptop", Description = "Brand new", Category = "Electronics", Price = 200.99m, StockQty = 10, Discount = 0.1m },
            //    new Product() {  Name = "Pencil", Description = "Yellow", Category = "School", Price = 1.99m, StockQty = 200, Discount = 0 },
            //    new Product() { Name = "Samsung Phone", Description = "Brand New", Category = "Electronics", Price = 599.99m, StockQty = 80, Discount = 0 },
            //    new Product() {  Name = "Iphone Cable", Description = "2 foot", Category = "Electronics", Price = 6.99m, StockQty = 100, Discount = 0.2m },
            //    new Product() {  Name = "Samsung TV", Description = "50 Inches", Category = "Electronics", Price = 300m, StockQty = 5, Discount = 0.1m },
            //    new Product() {  Name = "Bed", Description = "King Bed", Category = "Forniture", Price = 500.99m, StockQty = 100, Discount = 0 },
            //    new Product() {  Name = "Lamp", Description = "Stand Lamp", Category = "Forniture", Price = 30.99m, StockQty = 20, Discount = 0 },
            //    new Product() {  Name = "T-Shirt", Description = "white", Category = "Clothes", Price = 3.99m, StockQty = 60, Discount = 0.3m },
            //    new Product() { Name = "T-Shirt", Description = "Blue", Category = "Clothes", Price = 3.99m, StockQty = 50, Discount = 0 },
            //    new Product() {  Name = "T-Shirt", Description = "Red", Category = "Clothes", Price = 3.99m, StockQty = 24, Discount = 0.1m },
            //    new Product() {  Name = "H&m Jean", Description = "blue jean", Category = "Clothes", Price = 16.99m, StockQty = 245, Discount = 0 },
            //    new Product() {  Name = "Math Book", Description = "10 Grade", Category = "School", Price = 14.99m, StockQty = 56, Discount = 0 },
            //    new Product() {  Name = "wallet", Description = "Brown", Category = "Clothes", Price = 5.99m, StockQty = 80, Discount = 0.1m },
            //    new Product() {  Name = "Armani Glases", Description = "Dark", Category = "Clothes", Price = 80.99m, StockQty = 270, Discount = 0 },
            //    new Product() {  Name = "RayBan Glases", Description = "Vision", Category = "Clothes", Price = 100.99m, StockQty = 670, Discount = 0 },
            //    new Product() {  Name = "Ipad", Description = "Gray", Category = "Electronics", Price = 299m, StockQty = 230, Discount = 0 },
            //    new Product() { Name = "Notebook", Description = "Red", Category = "School", Price = 4.99m, StockQty = 30, Discount = 0.2m },
            //    new Product() { Name = "Roku", Description = "Roku 2", Category = "Electronics", Price = 50.99m, StockQty = 50, Discount = 0 },
            //    new Product() {  Name = "LG Washer", Description = "White", Category = "Electronics", Price = 400.99m, StockQty = 60, Discount = 0 },
            //    new Product() {  Name = "LG Dryer", Description = "White", Category = "Electronics", Price = 350.99m, StockQty = 80, Discount = 0 },
            //    new Product() {  Name = "Pen", Description = "Black", Category = "School", Price = 10.99m, StockQty = 20, Discount = 0 },
            //    new Product() {  Name = "Board Eraser", Description = "Green", Category = "School", Price = 5.99m, StockQty = 200, Discount = 0.1m },
            //    new Product() {  Name = "Bagpack", Description = "Purple", Category = "School", Price = 23.99m, StockQty = 450, Discount = 0 },
            //    new Product() {  Name = "Chair", Description = "Old Style", Category = "Forniture", Price = 141.99m, StockQty = 10, Discount = 0 },
            //    new Product() {  Name = "Love Seat", Description = "Brown", Category = "Forniture", Price = 300m, StockQty = 4, Discount = 0 },
            //    new Product() {  Name = "Adidas shoes", Description = "Black and White", Category = "Clothes", Price = 59.99m, StockQty = 300, Discount = 0.1m },
            //    new Product() {  Name = "Calculator", Description = "Blue", Category = "School", Price = 2.99m, StockQty = 100, Discount = 0 },
            //    new CartProduct()
            //    {
            //        Name = "short",
            //        Description = "nike",                   
            //        Price = 12.4m,
            //        Category = "Clothes",
            //        Discount = 1m,
            //        StockQty = 34,
            //        OrderQty = 2,
            //    }
             //   );

            ////Roles
            //context.Roles.AddOrUpdate(
            //p => p.Name,
            //new ApplicationRole { Name = "Admin" },
            //new ApplicationRole { Name = "Customer" }
            //);          

                
        }
    }
}
