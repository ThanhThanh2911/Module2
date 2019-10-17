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
    public class CreateModel : PageModel
    {
        private readonly IStudentData studentData;

        [BindProperty(SupportsGet =true)]
        public Student Student { get; set; }
        public CreateModel(IStudentData studentData)
        {
            this.studentData = studentData;
        }
        public IActionResult OnGet(Student newStudent)
        {
            Student = new Student();
            return Page();
        }
        public IActionResult OnPost()
        {
            Student = studentData.Add(Student);
            studentData.Commit();
            return RedirectToPage("./List");
        }

    }
}