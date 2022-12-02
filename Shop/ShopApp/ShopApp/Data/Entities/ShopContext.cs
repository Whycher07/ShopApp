using Microsoft.EntityFrameworkCore;
using ShopApp.Models.Configrations;
using System.Security.Cryptography.X509Certificates;

namespace ShopApp.Data.Entities
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {


        }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Unit> Units => Set<Unit>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Order> orders => Set<Order>();
        public DbSet<OrderLine> OrderLines => Set<OrderLine>();
        public DbSet<Customer> custumers => Set<Customer>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
