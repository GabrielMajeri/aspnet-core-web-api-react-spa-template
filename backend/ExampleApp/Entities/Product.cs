using System.ComponentModel.DataAnnotations;

namespace ExampleApp.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
