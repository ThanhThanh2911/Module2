using System;
using System.ComponentModel.DataAnnotations;

namespace StudentApp.Core
{
    public class Student
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }
        public string Address { get; set; }
        public Skill Skill { get; set; }
    }
}
