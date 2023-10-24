using System.ComponentModel.DataAnnotations;

namespace ShopApplication.Models
{
    public class User
    {

        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();


        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
