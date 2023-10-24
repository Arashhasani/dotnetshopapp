using ShopApplication.Entity;
using ShopApplication.Models;

namespace ShopApplication.Services
{
    public class UserService : IUserService
    {

        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public User findUserByEmailAndPassword(string email, string password)
        {
            return _context.Users.Where(u => u.Email == email).Where(u => u.Password == password).FirstOrDefault();
        }
    }
}
