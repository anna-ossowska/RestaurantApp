﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

// Represents classes and algorithms that are the core of application

namespace RestaurantApp.Core
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; }

        [Required, StringLength(255)]
        public string Location { get; set; }

        public CuisineType Cuisine { get; set; }
    }
}
