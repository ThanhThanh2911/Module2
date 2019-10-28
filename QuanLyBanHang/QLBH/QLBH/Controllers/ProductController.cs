using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLBH.Models;

namespace QLBH.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext db;

        public ProductController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult List(int id)
        {
            var product = from p in db.Products.Include(p => p.ProductType).ToList()
                          select p;
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.ProductType = db.ProductTypes.SingleOrDefault(pr => pr.ProductTypeId == id).ProductTypeName;
            return View(product);
        }
    }
}