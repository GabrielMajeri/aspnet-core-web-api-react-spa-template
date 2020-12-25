using ExampleApp.Entities;
using Microsoft.Extensions.Logging;

namespace ExampleApp.Data
{
    public class DataSeeder
    {
        private readonly AppDbContext _context;
        private readonly ILogger<DataSeeder> _logger;

        public DataSeeder(AppDbContext context, ILogger<DataSeeder> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Seed()
        {
            if (_context.Database.EnsureCreated() == false)
            {
                // Database already exists, don't try to seed it
                return;
            }

            _logger.LogInformation("Seeding database");

            var products = new Product[]
            {
                new Product { Name = "Pizza", Price = 15.0 },
                new Product { Name = "Carrot", Price = 2.0 },
            };

            _context.AddRange(products);
            _context.SaveChanges();

            _logger.LogInformation($"Added {products.Length} seed products to the database");
        }
    }
}
