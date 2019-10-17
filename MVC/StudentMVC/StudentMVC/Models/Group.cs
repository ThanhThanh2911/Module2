using System;
using System.Collections.Generic;

namespace StudentMVC.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }

        public List<Student> Students { get; set; }
    }
}