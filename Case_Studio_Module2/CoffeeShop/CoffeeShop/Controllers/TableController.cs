using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;
using CoffeeShop.Models.Repository;
using CoffeeShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class TableController : Controller
    {
        private readonly AppDbContext _db;
        private readonly Table _table;

        public TableController(AppDbContext db, Table table)
        {
            _db = db;
            _table = table;
        }
        public IActionResult Index()
        {
            var items = _table.GetOrders();
            _table.Orders = items;

            var tableVM = new TableViewModel
            {
                Table = _table,
                TableTotal = _table.GetTableTotal()
            };

            return View(tableVM);
        }

        public RedirectToActionResult AddToTable(int drinkId)
        {
            var selectDrink = _db.Drinks.FirstOrDefault(d => d.Id == drinkId);
            if (selectDrink != null)
            {
                _table.AddToTable(selectDrink, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromTable(int drinkId)
        {
            var selectDrink = _db.Drinks.FirstOrDefault(d => d.Id == drinkId);
            if (selectDrink != null)
            {
                _table.RemoveFromTable(selectDrink);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult Add(int drinkId)
        {
            var selectDrink = _db.Drinks.FirstOrDefault(d => d.Id == drinkId);
            if (selectDrink != null)
            {
                _table.EditAddDrink(selectDrink);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult Mul(int drinkId)
        {
            var selectDrink = _db.Drinks.FirstOrDefault(d => d.Id == drinkId);
            if (selectDrink != null)
            {
                _table.EditMulDrink(selectDrink);
            }
            return RedirectToAction("Index");
        }
    }
}