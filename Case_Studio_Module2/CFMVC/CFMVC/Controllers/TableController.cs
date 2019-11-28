using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CFMVC.Models;
using CFMVC.Models.Repository;
using CFMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CFMVC.Controllers
{
    public class TableController : Controller
    {
        private readonly IDrinkRepo _drinkRepo;
        private readonly Table _table;

        public TableController(IDrinkRepo drinkRepo, Table table)
        {
            _drinkRepo = drinkRepo;
            _table = table;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddOrders()
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
            var selectDrink = _drinkRepo.Drinks.FirstOrDefault(d => d.Id == drinkId);
            if (selectDrink != null)
            {
                _table.AddToTable(selectDrink, 1);
            }

            return RedirectToAction("AddOrders");
        }

        public RedirectToActionResult RemoveFromTable(int drinkId)
        {
            var selectDrink = _drinkRepo.Drinks.FirstOrDefault(d => d.Id == drinkId);
            if (selectDrink != null)
            {
                _table.RemoveFromTable(selectDrink);
            }

            return RedirectToAction("AddOrders");
        }

        public RedirectToActionResult Add(int drinkId)
        {
            var selectDrink = _drinkRepo.Drinks.FirstOrDefault(d => d.Id == drinkId);
            if (selectDrink != null)
            {
                _table.EditAddDrink(selectDrink);
            }
            return RedirectToAction("AddOrders");
        }

        public RedirectToActionResult Mul(int drinkId)
        {
            var selectDrink = _drinkRepo.Drinks.FirstOrDefault(d => d.Id == drinkId);
            if (selectDrink != null)
            {
                _table.EditMulDrink(selectDrink);
            }
            return RedirectToAction("AddOrders");
        }
    }
}