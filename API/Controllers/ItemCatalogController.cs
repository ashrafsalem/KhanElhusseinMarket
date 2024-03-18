
using Core.Entities;
using Infrasructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemCatalogController : ControllerBase
    {
        private readonly StoreContext _storeContext;

        public ItemCatalogController(StoreContext storeContext)
        {
            this._storeContext = storeContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<ItemCatalog>>> GetItemCatalogs()
        {
            return await _storeContext.ItemCatalogs.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ItemCatalog>> GetItemCatalog(int id)
        {
            return await _storeContext.ItemCatalogs.FindAsync(id);
        }
    }
}