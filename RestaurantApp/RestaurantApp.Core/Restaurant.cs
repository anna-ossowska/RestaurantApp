using System;
using System.Collections.Generic;
using System.Text;

// Represents classes and algorithms that are the core of application

namespace RestaurantApp.Core
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
