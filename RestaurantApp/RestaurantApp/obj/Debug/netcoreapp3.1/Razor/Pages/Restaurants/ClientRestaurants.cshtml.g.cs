#pragma checksum "C:\Users\tomas\Documents\anna\repos\RestaurantApp\RestaurantApp\RestaurantApp\Pages\Restaurants\ClientRestaurants.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb0848c9520e877b8ba1c70fa61ca6c6f3c82662"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RestaurantApp.Pages.Restaurants.Pages_Restaurants_ClientRestaurants), @"mvc.1.0.razor-page", @"/Pages/Restaurants/ClientRestaurants.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb0848c9520e877b8ba1c70fa61ca6c6f3c82662", @"/Pages/Restaurants/ClientRestaurants.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66ca96308bf0b3a2feb5a901d4a031fcca7e6940", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_ClientRestaurants : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Client Restaurants</h2>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            $.ajax(""/api/restaurants"",
                { method: ""get"" })
                .then(function (response) {
                    console.dir(response);
                });
        });



    </script>
");
            }
            );
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantApp.Pages.Restaurants.ClientRestaurantsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestaurantApp.Pages.Restaurants.ClientRestaurantsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestaurantApp.Pages.Restaurants.ClientRestaurantsModel>)PageContext?.ViewData;
        public RestaurantApp.Pages.Restaurants.ClientRestaurantsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
