using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLBH.Models;

namespace QLBH.Controllers
{
    public class ProductTypeController : Controller
    {
        private readonly AppDbContext db;

        public ProductTypeController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult List()
        {
            var listProductType = from pt in db.ProductTypes.Include(p => p.Products).ToList()
                                  select pt;
            return View(listProductType);
        }
    }
}