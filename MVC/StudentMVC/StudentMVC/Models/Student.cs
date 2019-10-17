using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string UrlImage { get; set; }
        public string History { get; set; }
        public bool Gender { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
