#pragma checksum "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\ItemCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eecdfbea3c853b1ac25fabba98e852d6e2f5797b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#line 66 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\ItemCard.razor"
       
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

    public bool ShowPopUp = false;
    public string ModalClass = "";
    public string ModalDisplay = "none";
    public bool ShowBackDrop = false;

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

        if (itemInCart >= 0)
        {
            CartStateProvider.ShoppingCart.Items[itemInCart].Quantity++;
        }
        else
        {
            CartStateProvider.ShoppingCart.Items.Add(item);
        }

        Console.WriteLine(CartStateProvider.ToString());

        ShowPopUp = await CartStateProvider.SaveChangesAsync();

        

        Console.WriteLine(ShowPopUp);

        OpenPopUp();

        await Task.Delay(2000);

        ShowPopUp = false;

        ClosePopUp();


    }

    public void OpenPopUp()
    {
        ModalClass = "show";
        ModalDisplay = "block";
        ShowBackDrop = true;
        StateHasChanged();
    }

    public void ClosePopUp()
    {
        ModalClass = "";
        ModalDisplay = "none";
        ShowBackDrop = false;
        StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazor.Extensions.Storage.Interfaces.ILocalStorage LocalStorage { get; set; }
    }
}
#pragma warning restore 1591
