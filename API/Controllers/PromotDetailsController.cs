using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PromotDetailsController : ControllerBase
    {
        [HttpGet]
        public string GetPromotDetails()
        {
            return "List of Promot Details";
        }

        [HttpGet("{id}")]
        public string GetPromotDetail(int id)
        {
            return "Single Promot Details";
        }
    }
}