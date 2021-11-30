using System;
using System.Collections.Generic;

#nullable disable

namespace Day17.Models
{
    public partial class Drug
    {
        public Drug()
        {
            PatientTakesMadicines = new HashSet<PatientTakesMadicine>();
        }

        public int DrugId { get; set; }
        public string DrugName { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<PatientTakesMadicine> PatientTakesMadicines { get; set; }
    }
}
