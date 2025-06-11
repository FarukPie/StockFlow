using Microsoft.EntityFrameworkCore;
using StockFlow.Entities;

namespace StockFlow.Context
{
    public class StoreContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-GCC8HOTA\\SQLEXPRESS;Initial Catalog=StoreFlowDb;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set;}

    }
}
