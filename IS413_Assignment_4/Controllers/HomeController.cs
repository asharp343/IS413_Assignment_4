using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IS413_Assignment_4.Models;

namespace IS413_Assignment_4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Restaurant> RestarantList = new List<Restaurant>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                r.Link = r.Link ?? "Coming Soon";
                r.FavDish = r.FavDish ?? "It's all tasty!";

                RestarantList.Add(r);
            }

            return View(RestarantList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Suggestions()
        {
            return View(TempStorage.Restaurants);
        }

        [HttpGet]
        public IActionResult SubmitSuggestion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitSuggestion(RestaurantSuggestions restaurant)
        {
            if (ModelState.IsValid)
            {
                restaurant.FavDish = restaurant.FavDish ?? "It's all tasty!";

                TempStorage.AddRestaurant(restaurant);
                return View("Suggestions", TempStorage.Restaurants);
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
