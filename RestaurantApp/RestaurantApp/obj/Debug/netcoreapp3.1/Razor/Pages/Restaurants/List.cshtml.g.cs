#pragma checksum "C:\Users\tomas\Documents\anna\repos\RestaurantApp\RestaurantApp\RestaurantApp\Pages\Restaurants\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "056ddf8d9385bdbb79fd63c432d0f65325c2dc0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RestaurantApp.Pages.Restaurants.Pages_Restaurants_List), @"mvc.1.0.razor-page", @"/Pages/Restaurants/List.cshtml")]
namespace RestaurantApp.Pages.Restaurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\tomas\Documents\anna\repos\RestaurantApp\RestaurantApp\RestaurantApp\Pages\_ViewImports.cshtml"
using RestaurantApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"056ddf8d9385bdbb79fd63c432d0f65325c2dc0a", @"/Pages/Restaurants/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60edd8a9d7f9677297cb917b9fbae1ef09db8277", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Restaurants</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Location</th>\r\n        <th>Cuisine</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\Users\tomas\Documents\anna\repos\RestaurantApp\RestaurantApp\RestaurantApp\Pages\Restaurants\List.cshtml"
     foreach (var restaurant in Model.Restaurants)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\tomas\Documents\anna\repos\RestaurantApp\RestaurantApp\RestaurantApp\Pages\Restaurants\List.cshtml"
           Write(restaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\tomas\Documents\anna\repos\RestaurantApp\RestaurantApp\RestaurantApp\Pages\Restaurants\List.cshtml"
           Write(restaurant.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\tomas\Documents\anna\repos\RestaurantApp\RestaurantApp\RestaurantApp\Pages\Restaurants\List.cshtml"
           Write(restaurant.Cuisine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 21 "C:\Users\tomas\Documents\anna\repos\RestaurantApp\RestaurantApp\RestaurantApp\Pages\Restaurants\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<div>");
#nullable restore
#line 24 "C:\Users\tomas\Documents\anna\repos\RestaurantApp\RestaurantApp\RestaurantApp\Pages\Restaurants\List.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantApp.Pages.Restaurants.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestaurantApp.Pages.Restaurants.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestaurantApp.Pages.Restaurants.ListModel>)PageContext?.ViewData;
        public RestaurantApp.Pages.Restaurants.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
