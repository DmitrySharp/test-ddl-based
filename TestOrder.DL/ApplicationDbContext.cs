using System.Data.Entity;
using TestOrder.Models.Entities;

namespace TestOrder.DL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(string connectionString) : base(connectionString)
        {
            
        }

        public DbSet<Models.Entities.TestOrder> TestOrders { get; set; }
        public DbSet<TestCategory> TestCategories { get; set; }
        public DbSet<TestProduct> TestProducts { get; set; }
        public DbSet<TestOrderProduct> TestOrderProducts { get; set; }
        public DbSet<TestProductCategory> TestProductCategories { get; set; }
    }
}
