using System;
using System.Collections.Generic;

#nullable disable

namespace StudentWebApi.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string FirstLanguage { get; set; }
        public int? Address { get; set; }
        public int? Father { get; set; }
        public int? Mother { get; set; }
        public int? Emergency { get; set; }
        public int? Reference { get; set; }

        public virtual Address AddressNavigation { get; set; }
        public virtual Father FatherNavigation { get; set; }
        public virtual Mother MotherNavigation { get; set; }
        public virtual Reference ReferenceNavigation { get; set; }
        public virtual Emergency EmergencyNavigation { get; set; }
    }
}
