using System.ComponentModel.DataAnnotations;

namespace ShopApplication.Models
{
    public class Products
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Name { get; set; }

        [Required]
        public int ProductPrice { get; set; }



        public Guid ProductCategoryId { get; set; } // Required foreign key property
        public ProductCategory? ProductCategory { get; set; } = null!; // Required reference navigation to principal

        public ICollection<ProductReceipt>? ProductReceipt { get; } = new List<ProductReceipt>();
        public ICollection<ProductTransfer>? productTransfers { get; } = new List<ProductTransfer>();
    }
}
