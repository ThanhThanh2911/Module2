using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentApp.Core;
using StudentApp.Data;

namespace StudentApp.Pages.Students
{
    public class EditModel : PageModel
    {
        private readonly IStudentData studentData;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Student Student { get; set; }

        public IEnumerable<SelectListItem> Skills { get; set; }
        public EditModel(IStudentData studentData, IHtmlHelper htmlHelper)
        {
            this.studentData = studentData;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int studentId)
        {
            Student = new Student();
            Student = studentData.EditById(studentId);
            Skills = htmlHelper.GetEnumSelectList<Skill>();
            if (Student == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            Skills = htmlHelper.GetEnumSelectList<Skill>();
            Student = studentData.Update(Student);
            studentData.Commnit();
            //return Page();
            return RedirectToPage("./Detail", new { studentId = Student.Id });
        }
    }
}