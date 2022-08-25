using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools.Models

{
    public class Studentdb
    {
        public class StudentContext : DbContext
        {
            public StudentContext(DbContextOptions options) : base(options)
            {

            }


            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Server=.;Database=Bankappdb;Trusted_Connection=True;");
                }
            }
            public DbSet<Student> Student { get; set; }
            public DbSet<Studentdb> Studentdb { get; set; }
           
        }
    }
}
