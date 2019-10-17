using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using StudentApp.Core;
using StudentApp.Data;

namespace StudentApp.Pages.Students
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IStudentData studentData;

        public string Message { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchKeyWord { get; set; }
        public IEnumerable<Student> Students { get; set; }

        public ListModel(IConfiguration config, IStudentData studentData)
        {
            this.config = config;
            this.studentData = studentData;
        }
        public void OnGet()
        {
            Message = config["Message"];
            Students = studentData.GetStudentByName(SearchKeyWord);
        }
    }
}