using BlazorApp3.models;
using BlazorApp3.repos.interfaces;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp3.Pages
{
    partial class ProductProfile : ComponentBase
    {
        [Inject]
        protected IProductRepository ProductRepository { get; set; } = null!;

        protected string SearchTerm { get; set; } = string.Empty;
        protected List<Product>? SearchResults { get; set; } = null;
        [Parameter]
        public int Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            SearchResults = await ProductRepository.GetAllProducts();
        }

        protected async Task SearchProducts()
        {
            if (!string.IsNullOrWhiteSpace(SearchTerm))
            {
                SearchResults = await ProductRepository.GetProductByQuery(SearchTerm);
            }
            else
            {
                SearchResults = await ProductRepository.GetAllProducts();
            }
        }
    }
}
