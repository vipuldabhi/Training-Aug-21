using System;
using System.Collections.Generic;

namespace Day11.Models
{
    public partial class DoctorWithPatient
    {
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public int? AssistantId { get; set; }
        public DateTime TreatementDate { get; set; }
    }
}
