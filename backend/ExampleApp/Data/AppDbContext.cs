using ExampleApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExampleApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; }
    }
}
