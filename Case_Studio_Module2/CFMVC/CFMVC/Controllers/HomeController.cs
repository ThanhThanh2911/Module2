using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CFMVC.Models;
using CFMVC.Models.Repository;

namespace CFMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDrinkRepo drinkRepo;

        public HomeController(ILogger<HomeController> logger, IDrinkRepo drinkRepo)
        {
            _logger = logger;
            this.drinkRepo = drinkRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SearchProduct([Bind] string searchName, IEnumerable<Drink> drinks)
        {
            drinks = drinkRepo.GetByDrink(searchName);
            if (drinks == null)
            {
                return NotFound();
            }
            ViewBag.Product = "No Product!!!";
            return View(drinks);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
