using StudentApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentApp.Data
{
    public class InMemoryStudentData : IStudentData
    {
        public List<Student> Students { get; set; }

        public InMemoryStudentData()
        {
            Students = new List<Student>()
            {
                new Student {Id = 1, Name = "Bon", Address = "1 Ngo Quyen", Skill = Skill.TanGai},
                new Student {Id = 2, Name = "Hieu", Address = "3 Ngo Quyen", Skill = Skill.HeadShot},
                new Student {Id = 3, Name = "Quy", Address = "2 Ngo Quyen", Skill = Skill.None},
            };
        }
        public IEnumerable<Student> GetStudentByName(string name = null)
        {
            return from s in Students
                   where string.IsNullOrEmpty(name) || s.Name.StartsWith(name.ToUpper())
                   orderby s.Name
                   select s;
        }

        public Student GetById(int studentId)
        {
            return Students.SingleOrDefault(s => s.Id == studentId);
        }

        public Student Update(Student updateStudent)
        {
            var student = Students.SingleOrDefault(s => s.Id == updateStudent.Id);
            if (student != null)
            {
                student.Name = updateStudent.Name;
                student.Address = updateStudent.Address;
                student.Skill = updateStudent.Skill;
            }
            return student;
        }

        public int Commnit()
        {
            return 0;
        }

        public Student EditById(int studentId)
        {
            return Students.SingleOrDefault(s => s.Id == studentId);
        }
    }
}
