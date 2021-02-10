using System;
using System.Collections.Generic;

namespace IS413_Assignment_4.Models
{
    public class TempStorage
    {
        public TempStorage()
        {
        }

        private static List<RestaurantSuggestions> restaurants = new List<RestaurantSuggestions>();

        public static IEnumerable<RestaurantSuggestions> Restaurants => restaurants;

        public static void AddRestaurant(RestaurantSuggestions restaurant)
        {
            restaurants.Add(restaurant);
        }
    }
}
