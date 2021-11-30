using System;
using System.Collections.Generic;

#nullable disable

namespace Day17.Models
{
    public partial class Department
    {
        public Department()
        {
            Doctors = new HashSet<Doctor>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
