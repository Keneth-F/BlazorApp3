using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorApp3.models;

namespace BlazorApp3.repos.interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductById(int id);
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetProductByQuery(string query);
    }
}
