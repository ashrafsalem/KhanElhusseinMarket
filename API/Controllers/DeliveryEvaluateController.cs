using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryEvaluateController : ControllerBase
    {
        [HttpGet]
        public string GetDeliveryEvaluates()
        {
            return "List Of DeliveryEvaluates";
        }

        [HttpGet("{id}")]
        public string GetDeliveryEvaluate(int id)
        {
            return "Single DeliveryEvaluate";
        }
    }
}