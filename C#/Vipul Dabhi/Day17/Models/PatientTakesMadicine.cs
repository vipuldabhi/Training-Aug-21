using System;
using System.Collections.Generic;

#nullable disable

namespace Day17.Models
{
    public partial class PatientTakesMadicine
    {
        public int Id { get; set; }
        public int? Patient { get; set; }
        public int? Drug { get; set; }
        public int? Assistance { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual Assistance AssistanceNavigation { get; set; }
        public virtual Drug DrugNavigation { get; set; }
        public virtual Patient PatientNavigation { get; set; }
    }
}
