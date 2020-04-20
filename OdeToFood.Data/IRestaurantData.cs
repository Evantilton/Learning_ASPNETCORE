using System;
using System.Collections.Generic;
using OdeToFood.Core
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
    public class InMemoryRestaurantData: IRestaurantData
    {
       readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza", Location = "Maryland", Cuisine=CuisineType.Italian},
            };
        }

        public IEnumerable<Restaurant> GetAll()
            from r in restaurants
          orderby r.Name
           select r;
    }
}

class Restaurant
{
}