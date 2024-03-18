using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrasructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ItemCatalogRepository : IItemCatalogRepository
    {
        // dependency injection
        // for store database
        private readonly StoreContext _context;
        public ItemCatalogRepository(StoreContext context)
        {
            this._context = context;
            
        }
        public async Task<ItemCatalog> GetItemCatalogByIdAsync(int id)
        {
            return await _context.ItemCatalogs.FindAsync(id);
        }

        public async Task<IReadOnlyList<ItemCatalog>> GetItemCatalogsAsync()
        {
            return await _context.ItemCatalogs.ToListAsync();
        }
    }
}