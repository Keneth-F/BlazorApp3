using BlazorApp3.models;
using BlazorApp3.repos.interfaces;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp3.Pages
{
    partial class ProductDetails : ComponentBase
    {
        [Inject]
        protected IProductRepository ProductRepository { get; set; } = null!;
        [Inject]
        protected NavigationManager nav { get; set; } = null!;

        [Parameter]
        public int Id { get; set; }

        public Product Product { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Product = await ProductRepository.GetProductById(Id);
            }
            catch (Exception)
            {
                nav.NavigateTo("/product-profile");
            }
        }
    }
}
