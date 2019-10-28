using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentMVC.Models;

namespace StudentMVC.Controllers
{
    public class GroupController : Controller
    {
        private readonly AppDbContext db;

        public GroupController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult List(int id)
        {
            var groups = db.Groups.SingleOrDefault(g => g.GroupId == id);
            if (groups == null)
            {
                return NotFound();
            }

            var listStudent = db.Students.Where(g => g.GroupId == id).OrderBy(g => g.Group.GroupName).ToList();
            if (listStudent.Count == 0)
            {
                ViewBag.Student = "Not Student!!";
            }
            return View(listStudent);
        }
    }
}