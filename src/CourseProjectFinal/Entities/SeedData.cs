using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectFinal.Entities
{
    public static class SeedData
    {
        public static void Seed(ApplicationDbContext context)
        {
            using (context)
            {
                context.AddRange(new Person
                {
                    PersonId = 1,
                    FirstName = "John",
                    LastName = "Happy"
                },
               new Person
               {
                   PersonId = 2,
                   FirstName = "Joey",
                   LastName = "Johnson"

               }
           );

                // Perform seed operations
                context.AddRange(new Address
                {
                    AddressId = 1,
                    City = "Plano",
                    StreetName = "!23 My Street",
                    PersonId = 1,
                    ZipCode = "75013",
                    State = "TX"
                },
                new Address
                {
                    AddressId = 2,
                    City = "Allen",
                    StreetName = "Jackson",
                    PersonId = 2,
                    ZipCode = "75010",
                    State = "TX"

                });

                context.SaveChanges();
                context.Dispose();
            }
        }
    }
}
