using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication12.Models;
using WebApplication12.Models.Repository;

namespace WebApplication12.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo _productRepo;
        private readonly ITableRepo _tableRepo;

        IEnumerable<Product> Products { get; set; }
        public ProductController(IProductRepo productRepo, ITableRepo tableRepo)
        {
            _productRepo = productRepo;
            _tableRepo = tableRepo;
        }
        public IActionResult Index()
        {
            Products = _productRepo.GetAll();
            return View(Products);
        }

        public RedirectToActionResult AddToTables(int id,int tableId)
        {
            var items = _tableRepo.GetOrders(tableId);
            var selectDrink = _productRepo.GetById(id);

            //var tableId = table.TableId;
            if (selectDrink != null)
            {
                _productRepo.AddToTable(selectDrink, 1, tableId);
            }

            return RedirectToAction("AddOrder");
        }
    }
}