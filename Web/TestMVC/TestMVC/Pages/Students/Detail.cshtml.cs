using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentData;
using StudentModel;

namespace TestMVC.Pages.Students
{
    public class DetailModel : PageModel
    {
        private readonly IStudentData studentData;
        public Student Student { get; set; }
        public DetailModel(IStudentData studentData)
        {
            this.studentData = studentData;
        }
        public IActionResult OnGet(int studentId)
        {
            Student = studentData.GetById(studentId);
            if(Student == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}