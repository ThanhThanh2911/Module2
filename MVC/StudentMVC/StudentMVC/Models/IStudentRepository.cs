using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll { get;  }
        IEnumerable<Student> GetStudentByName(string name);
        Student Add(Student newStudent);
        Student GetById(int id);
        Student Update(Student updateStudent);
        Student Delete(int id);
        int Commit();
    }
}
