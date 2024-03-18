using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrasructure.Data
{
    // to handle DataBase and create tables based on Code First Approach
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCatalog> ItemCatalogs { get; set; }
        public DbSet<ItemSupplier> ItemSuppliers { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<ItemUnit> ItemUnits {get; set;}
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<PO> POs { get; set; }
        public DbSet<PODetail> PODetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<DeliveryEmp> DeliveryEmps { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<SalesOrderDetail> salesOrderDetails { get; set; }
        public DbSet<DeliveryEvaluate> DeliveryEvaluates { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Promot> Promots { get; set; }
        public DbSet<PromotDetail> PromotDetails { get; set; }
        public DbSet<Advertising> Advertisings {get; set;}

    }
}