using RestaurantApp.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RestaurantApp.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }

    public class HardcodedRestaurantData : IRestaurantData
    {
        public List<Restaurant> restaurants;

        public HardcodedRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Flavoroso", Location = "Stavanger", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Green Curry", Location = "Bergen", Cuisine = CuisineType.Indian },
                new Restaurant { Id = 3, Name = "Salty Squid", Location = "Trondheim", Cuisine = CuisineType.Mexican},
                new Restaurant { Id = 4, Name = "El Pirata Porch", Location = "Sola", Cuisine = CuisineType.None }
            };
            
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }
}
