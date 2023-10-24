using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ShopApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {



        [HttpGet]
        [Authorize]
        public string homePage()
        {
            return "Home ...";
        }





    }
}
