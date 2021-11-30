using System;
using System.Collections.Generic;

#nullable disable

namespace Day17.Models
{
    public partial class Patient
    {
        public Patient()
        {
            PatientTakesMadicines = new HashSet<PatientTakesMadicine>();
            Treatments = new HashSet<Treatment>();
        }

        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string ContactNumber { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<PatientTakesMadicine> PatientTakesMadicines { get; set; }
        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}
