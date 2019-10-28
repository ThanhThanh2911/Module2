using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyTruongMamNon.Models;

namespace QuanLyTruongMamNon.Controllers
{
    public class PhuHuynhController : Controller
    {
        private readonly AppDbContext db;

        [BindProperty]
        public PhuHuynh PhuHuynh { get; set; }

        public PhuHuynhController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult List(string name)
        {
            var listPhuHuynh = from p in db.PhuHuynhs.Include(c => c.Children).ToList()
                               select p;
            if (!string.IsNullOrEmpty(name))
            {
                listPhuHuynh = db.PhuHuynhs.Where(p => p.TenPhuHuynh.Contains(name));
            }
            //var phuHuynh = from p in db.PhuHuynhs
            //               where string.IsNullOrEmpty(name) || p.TenPhuHuynh.Contains(name)
            //               select p;
            return View(listPhuHuynh);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind]PhuHuynh phuHuynh)
        {
            if (ModelState.IsValid)
            {
                db.PhuHuynhs.Add(phuHuynh);
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
            var phuHuynh = db.PhuHuynhs.FirstOrDefault(p => p.Id == id);
            if (phuHuynh == null)
            {
                return NotFound();
            }
            return View(phuHuynh);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var phuHuynh = db.PhuHuynhs.FirstOrDefault(p => p.Id == id);
            if (phuHuynh == null)
            {
                return NotFound();
            }
            return View(phuHuynh);
        }

        [HttpPost]
        public IActionResult Edit(int id, [Bind]PhuHuynh phuHuynh)
        {
            if (id != phuHuynh.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {

                db.PhuHuynhs.Update(phuHuynh);
                db.SaveChanges();

                return RedirectToAction("List");
            }
            return View(phuHuynh);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            } 
            var phuHuynh = db.PhuHuynhs.FirstOrDefault(p => p.Id == id);
            if (phuHuynh == null)
            {
                return NotFound();
            }
            return View(phuHuynh);
        }

        [HttpPost]
        public IActionResult Delete(int id, [Bind] PhuHuynh phuHuynh)
        {
            if (id != phuHuynh.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                db.PhuHuynhs.Remove(phuHuynh);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(phuHuynh);
        }
    }
}