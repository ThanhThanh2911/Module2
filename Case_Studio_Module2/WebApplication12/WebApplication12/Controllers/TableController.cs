using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication12.Models;
using WebApplication12.Models.Repository;
using WebApplication12.ViewModels;

namespace WebApplication12.Controllers
{
    public class TableController : Controller
    {
        private readonly ITableRepo _tableRepo;
        private readonly IProductRepo _productRepo;
        private readonly AppDbContext _db;

        IEnumerable<Table> Tables { get; set; }

        [BindProperty]
        public Table Table { get; set; }
        [BindProperty]
        public Order Order { get; set; }

        public TableController(ITableRepo tableRepo, IProductRepo productRepo, AppDbContext db)
        {
            _tableRepo = tableRepo;
            _productRepo = productRepo;
            _db = db;
        }
        public IActionResult Index()
        {
            TableViewModel tableViewModel = new TableViewModel();
            tableViewModel.Tables = _tableRepo.GetTables();
            return View(tableViewModel);
        }

        [HttpGet]
        public IActionResult AddOrder(int? id)
        {
            TableViewModel tableVM = new TableViewModel();
            if (id == null)
            {
                return NotFound();
            }
            tableVM.Table = _tableRepo.GetByTable(id.Value);
            if (tableVM.Table == null)
            {
                return NotFound();
            }
            return View(tableVM);
        }

        [HttpPost]
        public IActionResult AddOrder(int tableId, [Bind] Table _table)
        {
            try
            {
                var items = _tableRepo.GetOrders(tableId);
                _table.Orders = items;

                var tableVM = new TableViewModel
                {
                    TableTotal = _tableRepo.GetTableTotal(tableId)
                };

                return View(tableVM);
            }
            catch(Exception ex)
            {
                return View(new TableViewModel());
            }
        }




        public IActionResult AddToTable(int tableId, int id)
        {
            var selectDrink = _productRepo.Drinks.FirstOrDefault(d => d.ProductId == id);

            //var tableId = Table.TableId;
            if (selectDrink != null)
            {
                _tableRepo.AddToOrders(selectDrink, 1, tableId);
            }

            return RedirectToAction("AddOrder");
        }
    }
}