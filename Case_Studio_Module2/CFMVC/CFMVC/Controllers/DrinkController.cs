using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CFMVC.Models;
using CFMVC.Models.Repository;
using CFMVC.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CFMVC.Controllers
{
    public class DrinkController : Controller
    {
        private readonly IDrinkRepo drinkRepo;
        private readonly AppDbContext db;
        private readonly IHostingEnvironment hostingEnvironment;

        IEnumerable<Drink> Drinks { get; set; }
        public DrinkController(IDrinkRepo drinkRepo, AppDbContext db, IHostingEnvironment hostingEnvironment )
        {
            this.drinkRepo = drinkRepo;
            this.db = db;
            this.hostingEnvironment = hostingEnvironment;            
        }
        public IActionResult Index()
        {
            Drinks = drinkRepo.GetAll();
            return View(Drinks);
        }

        public IActionResult List()
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
        public IActionResult Create(ProductCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (model.Image !=null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Drink newDrink = new Drink
                {
                    Name = model.Name,
                    Price = model.Price,
                    ImgDrink = uniqueFileName,
                    DrinkTypeId = model.DrinkTypeId,
                };

                drinkRepo.Add(newDrink);
                drinkRepo.Commit();
                return RedirectToAction("Index");
            }
            ViewData["Name"] = new SelectList(db.DrinkTypes, "DrinkTypeId", "Name", model.Name);
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