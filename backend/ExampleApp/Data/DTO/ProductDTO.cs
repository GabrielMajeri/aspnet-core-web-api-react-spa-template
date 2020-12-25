using System.ComponentModel.DataAnnotations;

namespace ExampleApp.Data
{
    public class ProductDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
