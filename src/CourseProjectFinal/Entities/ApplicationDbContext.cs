using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectFinal.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public ApplicationDbContext()
        {
        }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Address> Addresses { get; set; }
    }
}
