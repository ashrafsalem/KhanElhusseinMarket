using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DevliveryEmpController : ControllerBase
    {
        [HttpGet]
        public string GetDevliveryEmps()
        {
            return "List Of DevliveryEmps";
        }

        [HttpGet("{id}")]
        public string GetDevliveryEmp(int id)
        {
            return "Single DevliveryEmp";
        }
    }
}