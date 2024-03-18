using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class POController : ControllerBase
    {
        [HttpGet]
        public string GetPOs()
        {
            return "List Of PO";
        }

        [HttpGet("{id}")]
        public string GetPO(int id)
        {
            return "Single PO";
        }
    }
}