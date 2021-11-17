using System;
using System.Collections.Generic;

namespace Day11.Models
{
    public partial class Assistance
    {
        public Assistance()
        {
            PatientTakesMadicine = new HashSet<PatientTakesMadicine>();
            Treatment = new HashSet<Treatment>();
        }

        public int AssistanceId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? WorkUnder { get; set; }
        public int YearOfExperience { get; set; }
        public bool IsActive { get; set; }

        public virtual Doctors WorkUnderNavigation { get; set; }
        public virtual ICollection<PatientTakesMadicine> PatientTakesMadicine { get; set; }
        public virtual ICollection<Treatment> Treatment { get; set; }
    }
}
