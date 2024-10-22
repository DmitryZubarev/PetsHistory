using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PetsHistory.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        public AccountController() 
        {
            
        }

        [HttpPost]
        public IActionResult Login()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Logout()
        {
            return Ok();
        }
    }
}
