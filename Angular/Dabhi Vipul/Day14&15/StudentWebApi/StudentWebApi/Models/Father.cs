using System;
using System.Collections.Generic;

#nullable disable

namespace StudentWebApi.Models
{
    public partial class Father
    {
        public Father()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Qualification { get; set; }
        public string Profession { get; set; }
        public string Designation { get; set; }
        public int? Phone { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
