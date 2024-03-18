using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PromotionsController : ControllerBase
    {
        [HttpGet]
        public string GetPromotions()
        {
            return "List Of Promotions";
        }

        [HttpGet("{id}")]
        public string GetPromotion(int id)
        {
            return "Single Promotion";
        }
    }
}