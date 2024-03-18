using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public string GetUsers()
        {
            return "List of users";
        }

        [HttpGet("{id}")]
        public string GetUser(int id)
        {
            return "Single User";
        }
    }
}