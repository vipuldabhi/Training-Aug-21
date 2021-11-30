using System;
using System.Collections.Generic;

#nullable disable

namespace Day17.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            Assistances = new HashSet<Assistance>();
            Treatments = new HashSet<Treatment>();
        }

        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public int YearOfExperience { get; set; }
        public int? Department { get; set; }
        public bool IsActive { get; set; }

        public virtual Department DepartmentNavigation { get; set; }
        public virtual ICollection<Assistance> Assistances { get; set; }
        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}
