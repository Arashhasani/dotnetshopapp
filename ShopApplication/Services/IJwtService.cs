using ShopApplication.Models;

namespace ShopApplication.Services
{
    public interface IJwtService
    {
        public string Generate(User user);
    }
}
