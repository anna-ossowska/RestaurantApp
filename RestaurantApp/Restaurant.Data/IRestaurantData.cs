using RestaurantApp.Core;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);

        Restaurant GetById(int id);

        Restaurant Update(Restaurant updatedRestaurant);

        int Commit();

        Restaurant Create(Restaurant newRestaurant);

        Restaurant Delete(int id);

        int GetCountOfRestaurants();
    }
}
