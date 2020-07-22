using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectFinal.Entities
{
    public class Person
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [NotMapped]
        public List<Address> Addresses { get; set; }

    }
}
