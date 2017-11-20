using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOnline.Models
{
    //description of a product EFramework Database Creation
    public class Product
    {      

        public Product() { }

        public int Id { get; set ; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public decimal Discount { get; set; }
        public int StockQty { get; set; }
        public int OrderQty { get; set; }
        public string Customer_Id { get; set; }

    }
}