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
    public class DeleteModel : PageModel
    {
        private readonly IStudentData studentData;
        
        [BindProperty]
        public Student Student { get; set; }
        public DeleteModel(IStudentData studentData)
        {
            this.studentData = studentData;
        }
        public IActionResult OnGet(int? studentId)
        {
            if (studentId.HasValue)
            {
                Student = studentData.GetById(studentId.Value);
            }
            if (Student == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (Student.Id > 0)
            {
                Student = studentData.Delete(Student.Id);
            }
            studentData.Commit();
            return RedirectToPage("./List", new { studentId = Student.Id });
        }

    }
}