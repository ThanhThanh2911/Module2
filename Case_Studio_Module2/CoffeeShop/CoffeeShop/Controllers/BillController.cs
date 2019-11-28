using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;
using CoffeeShop.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class BillController : Controller
    {
        private readonly IOrderRepo orderRepo;
        private readonly Table table;

        public BillController(IOrderRepo orderRepo, Table table)
        {
            this.orderRepo = orderRepo;
            this.table = table;
        }
        public IActionResult Payment()
        {
            return View();
        }
    }
}