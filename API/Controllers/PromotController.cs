using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PromotController : ControllerBase
    {
        [HttpGet]
        public string GetPromots()
        {
            return "List of All Promots";
        }

        [HttpGet("{id}")]
        public string GetPromot(int id)
        {
            return "Single Promot";
        }
    }
}