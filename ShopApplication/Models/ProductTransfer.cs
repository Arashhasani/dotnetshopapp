using System.ComponentModel.DataAnnotations;

namespace ShopApplication.Models
{
    public class ProductTransfer
    {

        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string SubmitDate { get; set; } = DateTime.Now.ToString();


        [Required]
        public int ProductNumber { get; set; }


        [Required]
        public int ProductPrice { get; set; }


        public int TotalPrice { get; set; }


        public Guid ProductId { get; set; } // Required foreign key property.

        public Products? Products { get; set; } = null!; // Required reference navigation to principal

    }
}
