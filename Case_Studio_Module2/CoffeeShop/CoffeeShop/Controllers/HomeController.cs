using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoffeeShop.Models;
using CoffeeShop.Models.Repository;
using CoffeeShop.ViewModels;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkRepo _drinkRepo;

        public HomeController(IDrinkRepo drinkRepo)
        {
            _drinkRepo = drinkRepo;
        }

        public IActionResult Index(string name)
        {
            HomeViewModel _homeVM = new HomeViewModel();
            _homeVM.Drinks = _drinkRepo.GetAll();
            return View(_homeVM);
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
