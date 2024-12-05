using System.ComponentModel.DataAnnotations;

namespace BlazorApp3.models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        public string Title { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que 0")]
        public decimal Price { get; set; }

        public string Description { get; set; }
        public String Image { get; set; }
    }
}
