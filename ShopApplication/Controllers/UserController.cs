using Microsoft.AspNetCore.Mvc;

using ShopApplication.Services;

namespace ShopApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        private readonly IJwtService _Jwtservice;
        public UserController(IUserService userService, IJwtService jwtservice)
        {
            _userService = userService;
            _Jwtservice = jwtservice;
        }

        [HttpPost]
        public string login([FromForm] string email, [FromForm] string password)
        {
            var user = _userService.findUserByEmailAndPassword(email, password);
            if (user == null)
            {
                return "This User not found ...";

            }
            var token = _Jwtservice.Generate(user);
            return token;

        }
    }
}
