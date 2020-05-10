#pragma checksum "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\Review.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "550866263b13da95001f1c56bc71f7450ec5b183"
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
#line 1 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\Review.razor"
using Blazor.Models;

#line default
#line hidden
    public partial class Review : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card mt-3");
            __builder.AddMarkupContent(2, "\r\n\r\n        ");
            __builder.AddMarkupContent(3, "<div class=\"card-header\">Reviews</div>\r\n\r\n");
#line 7 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\Review.razor"
         if (reviews == null)
        {

#line default
#line hidden
            __builder.AddContent(4, "            ");
            __builder.AddMarkupContent(5, "<p><em>Loading....</em></p>\r\n");
#line 10 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\Review.razor"
        }
        else
        {
            

#line default
#line hidden
#line 13 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\Review.razor"
             foreach (var review in reviews)
            {

#line default
#line hidden
            __builder.AddContent(6, "                ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "float-left mr-3");
            __builder.AddMarkupContent(12, "\r\n\r\n\r\n");
#line 19 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\Review.razor"
                          
                            var nrOfStars = review.getNrOfStars();
                            var maxStars = 5;

                            for (var i = 0; i < nrOfStars; i++)
                            {

#line default
#line hidden
            __builder.AddMarkupContent(13, "                                <i class=\"fas fa-star fa-sm\" style=\"color:#ffd800\"></i>\r\n");
#line 26 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\Review.razor"
                            }

                            if (maxStars > nrOfStars)
                            {
                                var starsLeft = maxStars - nrOfStars;
                                for (var j = 0; j < starsLeft; j++)
                                {

#line default
#line hidden
            __builder.AddMarkupContent(14, "                                    <i class=\"far fa-star fa-sm\"></i>\r\n");
#line 34 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\Review.razor"
                                }
                            }
                        

#line default
#line hidden
            __builder.AddContent(15, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, "<span> | </span>\r\n                    ");
            __builder.OpenElement(18, "p");
            __builder.AddAttribute(19, "class", "card-title text-primary ml-3");
            __builder.AddAttribute(20, "style", "display:inline-block;");
            __builder.AddContent(21, 
#line 39 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\Review.razor"
                                                                                           review.title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n\r\n\r\n                    ");
            __builder.OpenElement(23, "p");
            __builder.AddAttribute(24, "class", "card-text");
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.AddContent(26, 
#line 44 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\Review.razor"
                         review.comment

#line default
#line hidden
            );
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n                    ");
            __builder.OpenElement(29, "p");
            __builder.AddAttribute(30, "class", "card-author card-text");
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "small");
            __builder.AddMarkupContent(33, "\r\n                            Posted by ");
            __builder.AddContent(34, 
#line 49 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\Review.razor"
                                       review.author_name

#line default
#line hidden
            );
            __builder.AddMarkupContent(35, " on 30/03/2020\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#line 53 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\Review.razor"

                if (!review.Equals(reviews.Last()))
                {

#line default
#line hidden
            __builder.AddMarkupContent(39, "                    <hr>\r\n");
#line 57 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\Review.razor"
                }
            }

#line default
#line hidden
#line 58 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\Review.razor"
             
        }

#line default
#line hidden
            __builder.AddContent(40, "    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 62 "C:\Users\Lterwingen\Desktop\switch1920\researchProject\apps\Blazor\ResearchProject-Blazor-frontend\Shared\Review.razor"
       
    [Parameter]
    public ReviewModel[] reviews { get; set; }


#line default
#line hidden
    }
}
#pragma warning restore 1591