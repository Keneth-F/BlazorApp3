using BlazorApp3.models;

namespace BlazorApp3.repos.interfaces
{
    public interface IProductRepository
    {
        Product GetProductById(int id);
    }
}
