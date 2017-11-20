using ShopOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopOnline.Controllers
{
    public class ProductController : Controller
    {
        //create an instance of the dbcontext
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Product and pass the result query to the view
        public ActionResult ProductsList()
        {

            var list = db.Products.Where(p => p.OrderQty == 0);           
           return View(list.ToList());
        }

        
        //given a valid id return the corresponding product
        public ActionResult Details(int? id)
        {
            if (id == null)
                throw new ArgumentNullException();

            var product = db.Products.Where(i => i.Id == id)
                .FirstOrDefault<Product>();
            return View(product);
        }

        //pass to the view de deleted product
        public ActionResult Delete(int? id)
        {
            if (id == null)
                throw new ArgumentNullException();

            var product = db.Products.Where(i => i.Id == id)
                .FirstOrDefault<Product>();
            
            return View(product);

            
        }

        ///given a valid id delete the corresponding product from the database
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var productToAdd = db.Products.Where(i => i.Id == id)
                .FirstOrDefault<Product>();

                db.Entry(productToAdd).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                return RedirectToAction("ProductsList");  
        }


        //pass to the view de updated product
        public ActionResult Update(int? id)
        {
            if (id == null)
                throw new ArgumentNullException();

            var product = db.Products.Where(i => i.Id == id)
               .FirstOrDefault<Product>();
            var productViewModel = new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,                
                Category = product.Category,
                Description = product.Description,
                Discount = product.Discount,
                StockQty = product.StockQty
            };
            return View(productViewModel);
        }

        ///given a valid id update the corresponding product in the database
        [HttpPost]
        public ActionResult Update(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                var productToAdd = new Product()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,                    
                    Category = product.Category,
                    Description = product.Description,
                    Discount = product.Discount,
                    StockQty = product.StockQty,
                    OrderQty = 0
                };
                
                db.Entry(productToAdd).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ProductsList");
            }
            return View();
        }

        //view to create the products
        public ActionResult Create()
        {
            return View();
        }

        //add the product to the database
        [HttpPost]
        public ActionResult Create(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                var productToAdd = new Product()
                {
                    Name= product.Name,
                    Price = product.Price,                    
                    Category = product.Category,
                    Description = product.Description,
                    Discount = product.Discount,
                    StockQty = product.StockQty,
                    OrderQty = 0
                };
                db.Products.Add(productToAdd);
                db.SaveChanges();
                return RedirectToAction("ProductsList");
            }

            return View(product);
        }

        ////////////////////////////////////////
        // CartProducts 

        // GET: Given a user gives his cart products
         
        [Authorize(Roles ="Customer")]
        public ActionResult GetUserCartProducts()
        {
            var userName = User.Identity.Name;
            var user = (Customer)db.Users.FirstOrDefault(u => u.UserName == userName);

            var result = db.Products.Where(p=>p.Customer_Id == user.Id);
            return View(result.ToList());

        }

        // add an item to the user cart
        public ActionResult AddCart(int? id)
        {
            if (id == null)
                throw new ArgumentNullException();

            var product = db.Products.FirstOrDefault(p => p.Id == id);

            var cp = new ProductViewModel()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Category = product.Category,                
                Discount = product.Discount,
                Price = product.Price,
                StockQty = product.StockQty,
                OrderQty = 1
            };
            return View(cp);
        }

        [HttpPost]
        public ActionResult AddCart(ProductViewModel model)
        {
            if (!ModelState.IsValid)
                throw new ArgumentException();

            var userName = User.Identity.Name;
            var user = (Customer)db.Users.
                FirstOrDefault(u => u.UserName == userName);

            var prod = db.Products.
            FirstOrDefault(p => p.Name == model.Name && p.Customer_Id == user.Id);           

            
            if (prod!=null)
            {
                prod.OrderQty += model.OrderQty;
                db.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            else
            {
                var product = new Product()
                {
                    Name = model.Name,
                    Description = model.Description,
                    Category = model.Category,
                    Discount = model.Discount,
                    Price = model.Price,
                    StockQty = model.StockQty,
                    OrderQty = model.OrderQty,
                    Customer_Id = user.Id
                };

                db.Products.Add(product);
                db.SaveChanges();
            }
               


            return RedirectToAction("GetUserCartProducts");
        }
    }
}
