using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;
using CoffeeShop.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoffeeShop.Controllers
{
    public class DrinkController : Controller
    {
        private readonly IDrinkRepo drinkRepo;
        private readonly AppDbContext db;

        IEnumerable<Drink> Drinks { get; set; }
        public DrinkController(IDrinkRepo drinkRepo, AppDbContext db)
        {
            this.drinkRepo = drinkRepo;
            this.db = db;
        }
        public IActionResult Index()
        {
            Drinks = drinkRepo.GetAll();
            return View(Drinks);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Name"] = new SelectList(db.DrinkTypes, "DrinkTypeId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind]Drink drink)
        {
            if (ModelState.IsValid)
            {
                drinkRepo.Add(drink);
                drinkRepo.Commit();
                return RedirectToAction("Index");
            }
            ViewData["Name"] = new SelectList(db.DrinkTypes, "DrinkTypeId", "Name", drink.Name);
            return View();
        }


        public IActionResult Detail(int id)
        {
            var drink = drinkRepo.GetById(id);
            if (drink == null)
            {
                return NotFound();
            }
            return View(drink);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var drink = drinkRepo.GetById(id.Value);
            if (drink == null)
            {
                return NotFound();
            }
            ViewData["Name"] = new SelectList(db.DrinkTypes, "DrinkTypeId", "Name");
            return View(drink);
        }

        [HttpPost]
        public IActionResult Edit([Bind]Drink drink)
        {
            if (ModelState.IsValid)
            {
                drinkRepo.Update(drink);
                drinkRepo.Commit();
                return RedirectToAction("Index");
            }
            ViewData["Name"] = new SelectList(db.DrinkTypes, "DrinkTypeId", "Name", drink.Name);
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var drink = drinkRepo.GetById(id.Value);
            if (drink == null)
            {
                return NotFound();
            }
            return View(drink);
        }

        [HttpPost]
        public IActionResult Delete([Bind]Drink drink)
        {
            if (ModelState.IsValid)
            {
                drinkRepo.Delete(drink);
                drinkRepo.Commit();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}