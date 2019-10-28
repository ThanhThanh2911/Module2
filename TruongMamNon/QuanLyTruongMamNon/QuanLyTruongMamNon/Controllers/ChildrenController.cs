using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyTruongMamNon.Models;

namespace QuanLyTruongMamNon.Controllers
{
    public class ChildrenController : Controller
    {
        private readonly AppDbContext db;

        public ChildrenController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult List(string name)
        {
            var childrens = from p in db.Childrens.Include(c => c.PhuHuynh).ToList()
                               select p;
            if (!string.IsNullOrEmpty(name))
            {
                childrens = db.Childrens.Where(p => p.Name.Contains(name));
            }
            //var phuHuynh = from p in db.PhuHuynhs
            //               where string.IsNullOrEmpty(name) || p.TenPhuHuynh.Contains(name)
            //               select p;
            return View(childrens);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind]Children childrens)
        {
            if (ModelState.IsValid)
            {
                db.Childrens.Add(childrens);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View();
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var children = db.Childrens.FirstOrDefault(p => p.Id == id);
            if (children == null)
            {
                return NotFound();
            }
            return View(children);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var children = db.Childrens.FirstOrDefault(p => p.Id == id);
            if (children == null)
            {
                return NotFound();
            }
            return View(children);
        }

        [HttpPost]
        public IActionResult Edit(int id, [Bind]Children children)
        {
            if (id != children.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {

                db.Childrens.Update(children);
                db.SaveChanges();

                return RedirectToAction("List");
            }
            return View(children);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var children = db.PhuHuynhs.FirstOrDefault(p => p.Id == id);
            if (children == null)
            {
                return NotFound();
            }
            return View(children);
        }
    }
}