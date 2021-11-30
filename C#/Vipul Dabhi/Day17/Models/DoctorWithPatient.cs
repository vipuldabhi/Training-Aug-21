using System;
using System.Collections.Generic;

#nullable disable

namespace Day17.Models
{
    public partial class DoctorWithPatient
    {
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public int? AssistantId { get; set; }
        public DateTime TreatementDate { get; set; }
    }
}
