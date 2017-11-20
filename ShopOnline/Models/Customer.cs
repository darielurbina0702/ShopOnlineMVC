using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOnline.Models
{
    //EFramework Database Creation 
    public class Customer : ApplicationUser
    {
        public Customer()
        {
            CartProducts = new List<Product>();

        }

        public decimal CustomerBalance { get; set; }
        // customer cart product items
        public ICollection<Product> CartProducts { get; set; }

    }
}