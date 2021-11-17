using System;
using System.Collections.Generic;

namespace Day11.Models
{
    public partial class Doctors
    {
        public Doctors()
        {
            Assistance = new HashSet<Assistance>();
            Treatment = new HashSet<Treatment>();
        }

        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public int YearOfExperience { get; set; }
        public int? Department { get; set; }
        public bool IsActive { get; set; }

        public virtual Departments DepartmentNavigation { get; set; }
        public virtual ICollection<Assistance> Assistance { get; set; }
        public virtual ICollection<Treatment> Treatment { get; set; }
    }
}
