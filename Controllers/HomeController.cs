using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Controllers
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
            List<string> restaurantList = new List<string>();

            // pre populated list of my top five preferred restaurants in the Provo area
            foreach(Restaurant r in Restaurant.TopFiveRestaurants())
            {
                if(r.FavoriteDish == "" | r.FavoriteDish == null)
                {
                    r.FavoriteDish = "It's all tasty!";
                    restaurantList.Add(string.Format("#" + r.Rank + ": " + r.Name + " -- " + r.FavoriteDish.ToUpper() + ". Anything you get will hit the spot! Go check them out at " + r.Address + ", or call them at " + r.PhoneNumber + ". Thier website is " + r.Website));
                }
                else
                {
                    restaurantList.Add(string.Format("#" + r.Rank + ": " + r.Name + " -- " + "My favorite thing to get here is the " + r.FavoriteDish.ToUpper() + " It is so delicious and hits the spot every time! Go check them out at " + r.Address + ", or call them at " + r.PhoneNumber + ". Thier website is " + r.Website));
                }
            }

            return View(restaurantList);
        }

        // httpget is for first visit to view page
        [HttpGet]
        public IActionResult Suggestions()
        {
            return View();
        }

        // httppost is for a button click
        [HttpPost]
        public IActionResult Suggestions(Suggestion suggestion)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddSuggestion(suggestion);
                return View(suggestion);
            }

            return View();
        }

        public IActionResult SuggestionList()
        {
            return View(TempStorage.Suggestions);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
