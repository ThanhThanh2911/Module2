﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            return View(product);
        }

        
        public IActionResult Create()
        {
            ViewData["ProductTypeId"] = new SelectList(db.ProductTypes, "ProductTypeId", "ProductTypeId");
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind]Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            ViewData["ProductTypeId"] = new SelectList(db.ProductTypes, "ProductTypeId", "ProductTypeId", product.ProductTypeId);
            return View();
        }
    }
}