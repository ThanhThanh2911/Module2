using Microsoft.EntityFrameworkCore;
using StudentApp.Core;
using System;

namespace StudentApp.Data
{
    public class StudentAppContext : DbContext
    {
        public StudentAppContext(DbContextOptions<StudentAppContext> options) : base(options)
        {
                
        }

        public DbSet<Student> Students { get; set; }
    }
}
