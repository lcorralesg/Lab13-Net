﻿using Microsoft.EntityFrameworkCore;
namespace Lab13.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\local;Database=Lab13DB;Integrated Security=true");
        }
    }
}
