using BlazorApp3.models;
using BlazorApp3.repos.interfaces;

namespace BlazorApp3.repos
{
    public class ProductRepository : IProductRepository
    {
        public Product GetProductById(int id) => new Product
        {
            Id = id,
            Name = $"Producto {id}",
            Price = 100.00m,
            Description = $"Descripción del producto {id}"
        };

    }
}
