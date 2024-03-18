using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalesOrderDetailsController : ControllerBase
    {
        [HttpGet]
        public string GetSalesOrderDetails()
        {
            return "List Of All Sales Order Details";
        }

        [HttpGet("{id}")]
        public string GetSalesOrder(int id)
        {
            return "Single Sales Order Details";
        }
    }
}