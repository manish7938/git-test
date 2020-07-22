using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectFinal.Entities
{
    public class Address
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public int AddressId { get; set; }

        public string StreetName { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public int PersonId { get; set; }

        [NotMapped]
        public Person MyPerson { get; set; }
    }
}
