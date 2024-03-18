using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class SuppliersController : ControllerBase
    {
        [HttpGet]
        public string GetSuppliers()
        {
            return "List Of Suppliers";
        }

        [HttpGet("{id}")]
        public string GetSupplier(int id)
        {
            return "Single Supplier";
        }
    }
}