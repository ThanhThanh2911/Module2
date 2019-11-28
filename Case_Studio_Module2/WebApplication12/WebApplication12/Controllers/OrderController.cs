using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication12.Models;
using WebApplication12.Models.Repository;

namespace WebApplication12.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepo _orderRepo;

        IEnumerable<Order> Orders { get; set; }
        public OrderController(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }
        public IActionResult Index()
        {
            Orders = _orderRepo.GetProduct();
            return View(Orders);
        }
    }
}