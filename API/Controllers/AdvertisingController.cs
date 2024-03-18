using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdvertisingController : ControllerBase
    {
        [HttpGet]
        public string GetAdvertisings()
        {
            return "List Of Advertisings";
        }

        [HttpGet("{id}")]
        public string GetAdvertising(int id)
        {
            return "Single Advertising";
        }
    }
}