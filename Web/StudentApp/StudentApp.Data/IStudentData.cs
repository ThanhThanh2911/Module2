using StudentApp.Core;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Data
{
    public interface IStudentData
    {
        IEnumerable<Student> GetStudentByName(string name);
        Student GetById(int studentId);
        Student EditById(int studentId);
        Student Update(Student updateStudent);
        int Commnit();
    }
}
