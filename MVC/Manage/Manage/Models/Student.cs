using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manage.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
