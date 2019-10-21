using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentMVC.Models
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext dbContext;

        public StudentRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Student> GetAll
        {
            get{
                return dbContext.Students.Include(g => g.Group);
            }            
        }

        public Student Add(Student newStudent)
        {
            dbContext.Add(newStudent);
            return newStudent;
        }

        public int Commit()
        {
            return dbContext.SaveChanges();
        }

        public Student Delete(int id)
        {
            var student = GetById(id);
            if (student != null)
            {
                dbContext.Students.Remove(student);
            }
            return student;
        }

        public Student GetById(int id)
        {
            return dbContext.Students.Include(g => g.Group).SingleOrDefault(s => s.StudentId == id);
        }

        public IEnumerable<Student> GetStudentByName(string name)
        {
            var result = from s in dbContext.Students.Include(g => g.Group)
                            where string.IsNullOrEmpty(name) || s.Name.Contains(name)
                            select s;
            return result;
        }

        public Student Update(Student updateStudent)
        {
            var entity = dbContext.Students.Attach(updateStudent);
            entity.State = EntityState.Modified;
            return updateStudent;
        }

        
    }
}
