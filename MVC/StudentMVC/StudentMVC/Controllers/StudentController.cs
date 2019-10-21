using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentMVC.Models;
using StudentMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }


        public IActionResult List(StudentsListViewModel studentsListViewModel)
        {
            studentsListViewModel.Students = studentRepository.GetAll;
            studentsListViewModel.student = "Xin chào!!!";
            studentsListViewModel.Students = studentRepository.GetStudentByName(studentsListViewModel.name);

            //ViewBag.student = "Xin chào!!!";

            return View(studentsListViewModel);
        }


        [HttpGet]
        public IActionResult Create()
        {
            Student newStudent = new Student();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student newStudent)
        {
            //Kiem tra co su thay doi k
            if (ModelState.IsValid)
            {
                studentRepository.Add(newStudent);
                studentRepository.Commit();
                return RedirectToAction("List");
            }
            return View();
        }


        public IActionResult Detail(int id)
        {
            var student = studentRepository.GetById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpGet]
        public IActionResult Edit(int? id, Student student)
        {
            if (id.HasValue)
            {
                student = studentRepository.GetById(id.Value);
            }           
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit ([Bind]Student student)
        {
            if (student.StudentId > 0)
            {
                studentRepository.Update(student);
            }
            studentRepository.Commit();
            
            return RedirectToAction("Detail", new { id = student.StudentId});                     
        }

        [HttpGet]
        public IActionResult Delete(int? id, Student student)
        {
            if (id.HasValue)
            {
                student = studentRepository.GetById(id.Value);
            }
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult Delete([Bind] Student student)
        {
            if (student.StudentId > 0)
            {
                studentRepository.Delete(student.StudentId);
                studentRepository.Commit();
                return RedirectToAction("List", new { id = student.StudentId });
            }           
            return View();
        }

        
    }
}
