using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMvcEf.Models
{
    public class PeopleDbContext:DbContext
    {
        public PeopleDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite("Data Source=people.db");
    }

    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
