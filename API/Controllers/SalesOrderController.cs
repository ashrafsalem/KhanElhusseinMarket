using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalesOrderController : ControllerBase
    {
        [HttpGet]
        public string GetSalesOrders()
        {
            return "List Of Sales Orders";
        }

        [HttpGet("{id}")]
        public string GetSalesOrder(int id)
        {  
            return "Single Sale Order";
        }
    }
}