using System.ComponentModel.DataAnnotations;

namespace ShopApplication.Models
{
    public class ProductCategory
    {

        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }

        public string categorycode { get; set; }


        public ICollection<Products> Products { get; } = new List<Products>();
    }
}
