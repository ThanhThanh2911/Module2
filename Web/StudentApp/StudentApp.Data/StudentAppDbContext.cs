using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using StudentApp.Core;

namespace StudentApp.Data
{
    public class StudentAppDbContext : DbContext
    {
        public StudentAppDbContext(DbContextOptions<StudentAppDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
