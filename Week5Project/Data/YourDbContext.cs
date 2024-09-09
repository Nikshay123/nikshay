using Microsoft.EntityFrameworkCore;
using Week5Project.Models;
using Week5Project.Models;
using YourProjectName.Models;

namespace YourProjectName.Data
{
    public class YourDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionStringHere");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureProduct(modelBuilder);
            // Add other model configurations if needed
        }

        private void ConfigureProduct(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            // Add other configurations for the Product entity if needed
        }
    }
}
