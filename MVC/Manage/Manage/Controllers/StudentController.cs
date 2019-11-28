using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Manage.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext db;

        public StudentController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var listStudent = from s in db.Students.Include(g => g.Group).ToList()
                              select s;
            return View(listStudent);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["GroupId"] = new SelectList(db.Groups, "GroupId", "GroupId");
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind]Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["GroupId"] = new SelectList(db.Groups, "GroupId", "GroupId", student.GroupId);
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = db.Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, [Bind]Student updateStudent)
        {
            if (id != updateStudent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                db.Students.Update(updateStudent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(updateStudent);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = db.Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = db.Students.Include(g => g.Group).FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id, [Bind] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            
            if (ModelState.IsValid)
            {
                db.Students.Remove(student);
                db.SaveChanges();
                //return NotFound();
            }
            return View(student);

        }
    }
}