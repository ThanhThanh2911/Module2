using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentData;
using StudentModel;

namespace TestMVC.Pages.Students
{
    public class EditModel : PageModel
    {
        private readonly IStudentData studentData;

        [BindProperty]
        public Student Student { get; set; }
        //cái ni dùng trực tiếp sql đc ah
        public EditModel(IStudentData studentData)
        {
            this.studentData = studentData;
        }
        public IActionResult OnGet(int? studentId)
        {
            //Nếu cái id ni khác null
            if (studentId.HasValue)
            {
                Student = studentData.GetById(studentId.Value);
            }
            if(studentId == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if(Student.Id > 0)
            {
                studentData.Update(Student);
            }
            studentData.Commit();
            //Trả về lại trnag Detail theo Id
            return RedirectToPage("./Detail", new {studentId = Student.Id});
        }
    }
}