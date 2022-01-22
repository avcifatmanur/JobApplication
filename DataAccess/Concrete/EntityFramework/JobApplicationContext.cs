using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class JobApplicationContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Job;Trusted_Connection=true");
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Borough> Boroughs { get; set; }
    }
}
