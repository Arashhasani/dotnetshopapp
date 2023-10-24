using ShopApplication.Models;

namespace ShopApplication.Services
{
    public interface IUserService
    {

        public User findUserByEmailAndPassword(string email, string password);
    }
}
