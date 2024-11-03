using BlazorApp3.models;
using BlazorApp3.repos.interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorApp3.Pages
{
    partial class ProductProfile: ComponentBase
    {
        [Inject]
        protected IProductRepository ProductRepository { get; set; }

        protected Product Product { get; set; }

        protected override void OnInitialized()
        {
            Product = ProductRepository.GetProductById(1);
        }
    }
}
