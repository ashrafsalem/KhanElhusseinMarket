using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemSuppliersController : ControllerBase
    {
        [HttpGet]
        public string GetItemSuppliers()
        {
            return "List Of ItemSuppliers";
        }

        [HttpGet("{id}")]
        public string GetItemSupplier(int id)
        {
            return "Single ItemSupplier";
        }
    }
}