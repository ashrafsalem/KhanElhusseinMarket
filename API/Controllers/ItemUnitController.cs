using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemUnitController : ControllerBase
    {
        [HttpGet]
        public string GetItemUnits(){
            return "All Item Units";
        }
        [HttpGet("{id}")]
        public string GetItemUnit(int id){
            return "Single Item Unit";
        }
    }
}