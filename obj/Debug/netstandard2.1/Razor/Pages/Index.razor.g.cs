#pragma checksum "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c942a45ff5881fc84a78b944d81744879d5dfadc"
// <auto-generated/>
#pragma warning disable 1591
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
#line 1 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Pages\Index.razor"
using Blazor.Models;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n");
#line 11 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Pages\Index.razor"
         if (products == null)
        {

#line default
#line hidden
            __builder.AddContent(6, "            ");
            __builder.AddMarkupContent(7, "<p><em>Loading...</em></p>\r\n");
#line 14 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Pages\Index.razor"
        }
        else
        {
            

#line default
#line hidden
#line 17 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Pages\Index.razor"
             foreach(var prod in products)
            {

#line default
#line hidden
            __builder.AddContent(8, "                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-sm-4");
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenComponent<Blazor.Shared.ItemCard>(12);
            __builder.AddAttribute(13, "prod", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazor.Models.Product>(
#line 20 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Pages\Index.razor"
                                     prod

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#line 22 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Pages\Index.razor"
            }

#line default
#line hidden
#line 22 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Pages\Index.razor"
             
        }

#line default
#line hidden
            __builder.AddContent(16, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 27 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Pages\Index.razor"
      
    Product[] products;

    protected override async Task OnInitializedAsync()
    {
        // products = await Http.GetJsonAsync<Product[]>("/sample-data/items.json");

        products = await Http.GetJsonAsync<Product[]>("http://localhost:3333/items/");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
