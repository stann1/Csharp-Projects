using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;

namespace University.Data
{
    public class UniversityContext : DbContext
    {
        public UniversityContext() : base("UniversitySystemDB")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Material> Materials { get; set; }
        
    }
}
