using StudentMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.ViewModels
{
    public class StudentsListViewModel
    {
        public IEnumerable<Student> Students { get; set; }
        public string student { get; set; }
    }
}
