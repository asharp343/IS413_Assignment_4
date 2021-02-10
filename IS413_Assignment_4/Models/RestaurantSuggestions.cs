using System;
using System.ComponentModel.DataAnnotations;

namespace IS413_Assignment_4.Models
{
    public class RestaurantSuggestions
    {
        public RestaurantSuggestions()
        {
        }

        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage = "Restaurant name is required")]
        public string RestaurantName { get; set; }

        public string? FavDish { get; set; } = "It's all tasty!";

        [Phone]
        public string Phone { get; set; }
    }
}
