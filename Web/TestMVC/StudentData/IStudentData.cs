using StudentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentData
{
    public interface IStudentData
    {
        IEnumerable<Student> GetStudentByName(string name);
        Student GetById(int studentId);
        Student Update(Student updateStudent);
        Student Add(Student newStudent);
        Student Delete(int studentId);
        int Commit();
    }
    

}
