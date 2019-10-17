using Microsoft.EntityFrameworkCore;
using StudentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentData
{
    public class StudentDataContext : DbContext
    {
        public StudentDataContext(DbContextOptions<StudentDataContext> options) : base (options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
