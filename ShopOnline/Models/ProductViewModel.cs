using System.ComponentModel.DataAnnotations;

namespace ShopOnline.Models
{
    //is use to bind the elements from my products view 
    //and controller
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Description")]
        [StringLength(200)]
        public string Description { get; set; }
        
        public string Image { get; set; }

        [Required]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Required]
        [Display(Name = "Category")]
        [StringLength(50)]
        public string Category { get; set; }
        [Required]
        [Display(Name = "Discount")]
        public decimal Discount { get; set; }
        [Required]
        [Display(Name = "StockQty")]
        public int StockQty { get; set; }

        [Display(Name = "Qty")]
        public int OrderQty { get; set; }
    }
}