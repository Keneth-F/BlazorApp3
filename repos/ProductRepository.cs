using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorApp3.models;
using BlazorApp3.repos.interfaces;
using System.Collections.Generic;

namespace BlazorApp3.repos
{
    public class ProductRepository : IProductRepository
    {
        private readonly HttpClient _httpClient;

        public ProductRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Product?> GetProductById(int id)
        {
            var product = await _httpClient.GetFromJsonAsync<Product>($"products/{id}");
            return product;
        }
        public async Task<List<Product>> GetProductByQuery(string query)
        {
            var Products = await GetAllProducts();
            return Products.Where(p => p.Title.Contains(query, StringComparison.OrdinalIgnoreCase))
                    .ToList();
        }
        public async Task<List<Product>> GetAllProducts()
        {
            var Products = await _httpClient.GetFromJsonAsync<List<Product>>("products");
            return Products ?? new List<Product>();
        }

        
 
    }
}
