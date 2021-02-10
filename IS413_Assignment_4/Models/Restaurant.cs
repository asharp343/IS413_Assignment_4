using System;
using System.ComponentModel.DataAnnotations;

namespace IS413_Assignment_4.Models
{
    public class Restaurant
    {

        public Restaurant()
        {
            this.Rank = 0;
        }

        public Restaurant(int Rank)
        {
            this.Rank = Rank;
        }

        [Required(ErrorMessage = "Rank is Required")]
        public int Rank { get; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        public string? FavDish { get; set; } = "It's all tasty!";

        [Required(ErrorMessage = "Address is Required")]
        public string Address { get; set; }

        [Phone]
        [RegularExpression("^\\D?(\\d{3})\\D?\\D?(\\d{3})\\D?(\\d{4})$", ErrorMessage = "Input Phone number like 555-555-5555")]
        public string Phone { get; set; }

        public string? Link { get; set; } = "Coming soon";

        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                Name = "Panda Express",
                FavDish = "Orange Chicken",
                Address = "123 Road, Provo, UT",
                Phone = "(801)-555-5555",
                Link = null
            };

            Restaurant r2 = new Restaurant(2)
            {
                Name = "Wendys",
                FavDish = "Cheeseburger",
                Address = "123 Lane, Provo, UT",
                Phone = "(801)-555-5555",
                Link = "wendys.com"
            };

            Restaurant r3 = new Restaurant(3)
            {
                Name = "Little Caesars",
                FavDish = "Pepperoni Pizza",
                Address = "123 Blvd, Provo, UT",
                Phone = "(801)-555-5555",
                Link = "littlecaesars.com"
            };


            Restaurant r4 = new Restaurant(4)
            {
                Name = "Chick-fil-a",
                FavDish = null,
                Address = "123 Circle, Provo, UT",
                Phone = "(801)-555-5555",
                Link = "chick-fil-a.com"
            };

            Restaurant r5 = new Restaurant(5)
            {
                Name = "Betos",
                FavDish = "Carne Asado Burrito",
                Address = "123 Way, Provo, UT",
                Phone = "(801)-555-5555",
                Link = "betosmexicanfood.com"
            };


            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
