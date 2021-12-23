using System;
using System.Collections.Generic;

#nullable disable

namespace StudentApi.Models
{
    public partial class Student
    {
        public Student()
        {
            Emergencies = new HashSet<Emergency>();
        }

        public int StudentId { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public DateTime? Dateofbirth { get; set; }
        public string Placeofbirth { get; set; }
        public string Firstlanguage { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int? Pin { get; set; }
        public string Fatherfirstname { get; set; }
        public string Fathermiddlename { get; set; }
        public string Fatherlastname { get; set; }
        public string Fatheremail { get; set; }
        public string Fatherqualification { get; set; }
        public string Fatherprofession { get; set; }
        public string Fatherdesignation { get; set; }
        public string Fatherphone { get; set; }
        public string Motherfirstname { get; set; }
        public string Mothermiddlename { get; set; }
        public string Motherlastname { get; set; }
        public string Motheremail { get; set; }
        public string Motherqualification { get; set; }
        public string Motherprofession { get; set; }
        public string Motherdesignation { get; set; }
        public string Motherphone { get; set; }
        public string Refdetails { get; set; }
        public string Refthrough { get; set; }
        public string Refaddress { get; set; }

        public virtual ICollection<Emergency> Emergencies { get; set; }
    }
}
