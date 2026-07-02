using System.ComponentModel.DataAnnotations;

namespace ClotheManagementSystem.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name Required")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Category Required")]
        public string Category { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Stock { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public bool IsActive { get; set; }
    }
}