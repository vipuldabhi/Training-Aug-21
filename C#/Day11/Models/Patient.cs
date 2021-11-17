using System;
using System.Collections.Generic;

namespace Day11.Models
{
    public partial class Patient
    {
        public Patient()
        {
            PatientTakesMadicine = new HashSet<PatientTakesMadicine>();
            Treatment = new HashSet<Treatment>();
        }

        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string ContactNumber { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<PatientTakesMadicine> PatientTakesMadicine { get; set; }
        public virtual ICollection<Treatment> Treatment { get; set; }
    }
}
