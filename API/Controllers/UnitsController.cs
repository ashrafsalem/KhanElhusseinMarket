using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UnitsController : ControllerBase
    {
        [HttpGet]
        public string GetUnits()
        {
            return "List Of Units";
        }

        [HttpGet("{id}")]
        public string GetUnit(int id)
        {
            return "Single Unit";
        }
    }
}