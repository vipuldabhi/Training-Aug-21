using System;
using System.Collections.Generic;

#nullable disable

namespace StudentWebApi.Models
{
    public partial class Address
    {
        public Address()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int? Pin { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
