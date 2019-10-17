using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using StudentApp.Core;
using StudentApp.Data;

namespace WebApplication01.Pages.Shared
{
    public class ListModel : PageModel
    {
        private readonly IStudentData studentData;

        public List<Student> Students { get; set; }
        public ListModel(IStudentData studentData )
        {
            this.studentData = studentData;
        }
        public void OnGet()
        {
            Students = studentData.GetAll();
        }
    }
}