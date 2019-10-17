using System;
using System.Collections.Generic;
using System.Text;
using StudentModel;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StudentData
{
    public class SqlStudentData : IStudentData
    {
        private readonly StudentDataContext dbContext;

        public SqlStudentData(StudentDataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Student Add(Student newStudent)
        {
            dbContext.Add(newStudent);
            return newStudent;
        }

        public int Commit()
        {
            //Mỗi lần thay đổi hay cập nhật chi cũng phải sài cái ni hết
            return dbContext.SaveChanges();
        }

        public Student Delete(int studentId)
        {
            var student = GetById(studentId);
            if (student != null)
            {
                dbContext.Students.Remove(student);
            }           
            return student;
        }

        public Student GetById(int studentId)
        {
            return dbContext.Students.SingleOrDefault(st => st.Id == studentId);
        }

        public IEnumerable<Student> GetStudentByName(string name)
        {
            var result = from s in dbContext.Students
                         where string.IsNullOrEmpty(name) || s.Name.StartsWith(name)
                         select s;
            return result;
        }

        public Student Update(Student updateStudent)
        {
            //Hàm hổ trợ Update dữ liệu
            var entity = dbContext.Students.Attach(updateStudent);
            entity.State = EntityState.Modified; //Modified ni là sử thay đổi
            //Thay đổi xong thì trả về lại cái thằng nớ
            return updateStudent;
        }
    }
}
