#pragma checksum "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Pages\ShoppingCart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7026231f7dda41ce5282ec024c91b0aba6663971"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Pages
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
#line 3 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Pages\ShoppingCart.razor"
using Blazor.Models;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/shoppingcart")]
    public partial class ShoppingCart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 84 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Pages\ShoppingCart.razor"
       
    Product[] products;
    Cart cart;

    [CascadingParameter]
    CartStateProvider cartStateProvider { get; set; }

    [Parameter] public int CartProductQuantity { get; set; }

    [Parameter]
    public EventCallback<ChangeEventArgs> QuantityChanged { get; set; }




    protected override async Task OnInitializedAsync()
    {
        var varcart = await LocalStorage.GetItem<Cart>("MyShoppingCart");
        Console.WriteLine(varcart);
        cart = varcart;
    }

    async Task RemoveItem(CartProduct product)
    {
        cartStateProvider.ShoppingCart.Items.Remove(product);

        // Update the cart - save to localstorage
        await cartStateProvider.SaveChangesAsync();

    }

    private async Task ChangeQuantityLocalStorage()
    {

        //Update total 

        var total = cartStateProvider.ShoppingCart.Total;


        Console.WriteLine(total.ToString());
        foreach(var item in cartStateProvider.ShoppingCart.Items)
        {
            Console.WriteLine(item.Total);
        }
        

        await cartStateProvider.SaveChangesAsync();
    }

    async Task ChangeQuantity(CartProduct product ,int quantity)
    {
        var selectedItem = cartStateProvider.ShoppingCart.Items.Find(x => x.Product == product.Product);

        // update quantity
        if(selectedItem !=null ) selectedItem.Quantity = quantity;

        await cartStateProvider.SaveChangesAsync();

    }



#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazor.Extensions.Storage.Interfaces.ILocalStorage LocalStorage { get; set; }
    }
}
#pragma warning restore 1591
