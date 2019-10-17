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

        public Student GetById(int id)
        {
            return dbContext.Students.Include(g => g.Group).SingleOrDefault(s => s.StudentId == id);
        }

        public Student Update(Student updateStudent)
        {
            var entity = dbContext.Students.Attach(updateStudent);
            entity.State = EntityState.Modified;
            return updateStudent;
        }
    }
}
