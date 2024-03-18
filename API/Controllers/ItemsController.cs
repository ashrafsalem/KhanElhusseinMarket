using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        [HttpGet]
        public string GetItems()
        {
            return "List Of Items";
        }

        [HttpGet("{id}")]
        public string GetItem(int id)
        {
            return "Single Item "+id.ToString();
        }
    }
}