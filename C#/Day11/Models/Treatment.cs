using System;
using System.Collections.Generic;

namespace Day11.Models
{
    public partial class Treatment
    {
        public int TreatementId { get; set; }
        public int? Patient { get; set; }
        public int? Doctor { get; set; }
        public int? Assistance { get; set; }
        public DateTime TreatementDate { get; set; }

        public virtual Assistance AssistanceNavigation { get; set; }
        public virtual Doctors DoctorNavigation { get; set; }
        public virtual Patient PatientNavigation { get; set; }
    }
}
