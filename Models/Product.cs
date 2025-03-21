using System.ComponentModel.DataAnnotations;

namespace RestfulApiProject.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}
