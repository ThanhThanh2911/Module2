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
    public class ListModel : PageModel
    {
        private readonly IStudentData studentData;

        [BindProperty(SupportsGet = true)]
        public string SearchKeyWord { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public ListModel(IStudentData studentData)
        {
            this.studentData = studentData;
        }
        public void OnGet()
        {
            Students = studentData.GetStudentByName(SearchKeyWord);
        }
    }
}