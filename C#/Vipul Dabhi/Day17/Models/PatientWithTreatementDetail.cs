using System;
using System.Collections.Generic;

#nullable disable

namespace Day17.Models
{
    public partial class PatientWithTreatementDetail
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string ContactNumber { get; set; }
        public bool IsActive { get; set; }
        public int TreatementId { get; set; }
        public int? Patient { get; set; }
        public int? Doctor { get; set; }
        public int? Assistance { get; set; }
        public DateTime TreatementDate { get; set; }
    }
}
