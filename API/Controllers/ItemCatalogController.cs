
using Core.Entities;
using Core.Interfaces;
using Infrasructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemCatalogController : ControllerBase
    {
        // using repository pattern
        // using IItemCatalogRepository as dependency injenction
        private readonly IItemCatalogRepository _repo;

        public ItemCatalogController(IItemCatalogRepository repo)
        {
            this._repo = repo;
            
        }
        [HttpGet]
        public async Task<ActionResult<List<ItemCatalog>>> GetItemCatalogs()
        {
            return Ok ( await _repo.GetItemCatalogsAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ItemCatalog>> GetItemCatalog(int id)
        {
            return await _repo.GetItemCatalogByIdAsync(id);
        }
    }
}