using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PODetailsController : ControllerBase
    {
        [HttpGet]
        public string GetPODetails()
        {
            return "List Of PODetails";
        }

        [HttpGet("{id}")]
        public string GetPODetail(int id)
        {
            return "Single PO Details";
        }
    }
}