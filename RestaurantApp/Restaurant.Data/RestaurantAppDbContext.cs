using Microsoft.EntityFrameworkCore;
using RestaurantApp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Data
{
    public class RestaurantAppDbContext : DbContext
    {
        public RestaurantAppDbContext(DbContextOptions<RestaurantAppDbContext> options)
            :base(options)
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
