using System;
using System.Collections.Generic;

#nullable disable

namespace Day17.Models
{
    public partial class Assistance
    {
        public Assistance()
        {
            PatientTakesMadicines = new HashSet<PatientTakesMadicine>();
            Treatments = new HashSet<Treatment>();
        }

        public int AssistanceId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? WorkUnder { get; set; }
        public int YearOfExperience { get; set; }
        public bool IsActive { get; set; }

        public virtual Doctor WorkUnderNavigation { get; set; }
        public virtual ICollection<PatientTakesMadicine> PatientTakesMadicines { get; set; }
        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}
