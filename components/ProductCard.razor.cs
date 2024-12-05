using BlazorApp3.models;
using Microsoft.AspNetCore.Components;

namespace BlazorApp3.components
{
    partial class ProductCard: ComponentBase
    {
        [Parameter]
        public Product Product { get; set; }
    }
}
