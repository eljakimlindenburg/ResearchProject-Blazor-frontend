#pragma checksum "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\ItemCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a1a2ac3f5be04d1cb32bb613c0a4f2328efe729"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\_Imports.razor"
using Blazor;

#line default
#line hidden
#line 7 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#line 1 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\ItemCard.razor"
using Blazor.Models;

#line default
#line hidden
    public partial class ItemCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "img");
            __builder.AddAttribute(4, "src", 
#line 6 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\ItemCard.razor"
               prod.image_src

#line default
#line hidden
            );
            __builder.AddAttribute(5, "alt", true);
            __builder.AddAttribute(6, "class", "card-img-top");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "h3");
            __builder.AddAttribute(12, "class", "card-title text-primary");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "href", "/detailpage/" + (
#line 8 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\ItemCard.razor"
                                                                  prod.id

#line default
#line hidden
            ));
            __builder.AddContent(15, 
#line 8 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\ItemCard.razor"
                                                                            prod.Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "h4");
            __builder.AddAttribute(18, "class", "card-price");
            __builder.AddContent(19, 
#line 9 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\ItemCard.razor"
                                prod.Price

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "p");
            __builder.AddAttribute(22, "class", "card-text");
            __builder.AddContent(23, 
#line 10 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\ItemCard.razor"
                              prod.Desc

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "card-body bg-light border-top");
            __builder.AddMarkupContent(28, "\r\n\r\n        ");
            __builder.AddMarkupContent(29, @"<div class=""float-left"">
            <i class=""far fa-star fa-sm""></i>
            <i class=""far fa-star fa-sm""></i>
            <i class=""far fa-star fa-sm""></i>
            <i class=""far fa-star fa-sm""></i>
            <i class=""far fa-star fa-sm""></i>
        </div>


        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "float-right");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.AddMarkupContent(33, "<button class=\"btn btn-secondary\">\r\n                <i class=\"far fa-heart fa-sm\"></i>\r\n            </button>\r\n            \r\n           ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn btn-primary");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 29 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\ItemCard.razor"
                                                     AddToBasket

#line default
#line hidden
            ));
            __builder.AddMarkupContent(37, "\r\n               <i class=\"fas fa-shopping-basket fa-sm\"></i>\r\n           ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, " \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 37 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\ItemCard.razor"
       
    [CascadingParameter] CartStateProvider CartStateProvider { get; set; }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public string Description { get; set; }

    [Parameter]
    public int Price { get; set; }

    [Parameter]
    public string Image_url { get; set; }

    [Parameter]
    public Product prod { get; set; }

    async Task AddToBasket(MouseEventArgs e)
    {


        var item = new CartProduct
        {
            Product = prod,
            Quantity = Convert.ToInt32(1)
        };

        var items = CartStateProvider.ShoppingCart.Items;
        var itemInCart = items.FindIndex(x => x.Product.Equals(item.Product));

        Console.WriteLine("Is the item already in the cart?" + itemInCart.ToString());

        if(itemInCart >= 0)
        {
            CartStateProvider.ShoppingCart.Items[itemInCart].Quantity++;
        }
        else
        {
            CartStateProvider.ShoppingCart.Items.Add(item);
        }

        Console.WriteLine(CartStateProvider.ToString());

        await CartStateProvider.SaveChangesAsync();

    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazor.Extensions.Storage.Interfaces.ILocalStorage LocalStorage { get; set; }
    }
}
#pragma warning restore 1591
