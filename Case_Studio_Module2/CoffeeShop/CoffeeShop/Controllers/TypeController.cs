using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class TypeController : Controller
    {
        private readonly AppDbContext db;

        public TypeController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index(int id)
        {
            var type = db.DrinkTypes.SingleOrDefault(t => t.DrinkTypeId == id);
            if (type == null)
            {
                return NotFound();
            }

            var listDrink = db.Drinks.Where(t => t.DrinkTypeId == id).OrderBy(t => t.DrinkType.Name).ToList();
            if (listDrink.Count == 0)
            {
                ViewBag.Drink = "Not Drink!!";
            }
            return View(listDrink);
        }
    }
}