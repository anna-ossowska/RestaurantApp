using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using RestaurantApp.Core;
using RestaurantApp.Data;

namespace RestaurantApp.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        public string Message{ get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        private readonly IConfiguration Config;

        private readonly IRestaurantData restaurantData;

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.Config = config;
            this.restaurantData = restaurantData;
        }

        public void OnGet(string searchTerm)
        {
            Message = Config["Message"];
            Restaurants = restaurantData.GetRestaurantsByName(SearchTerm);
        }
    }
}
