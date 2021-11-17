using System;
using System.Collections.Generic;

namespace Day11.Models
{
    public partial class Drugs
    {
        public Drugs()
        {
            PatientTakesMadicine = new HashSet<PatientTakesMadicine>();
        }

        public int DrugId { get; set; }
        public string DrugName { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<PatientTakesMadicine> PatientTakesMadicine { get; set; }
    }
}
