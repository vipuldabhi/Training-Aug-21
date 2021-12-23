using System;
using System.Collections.Generic;

#nullable disable

namespace StudentWebApi.Models
{
    public partial class Reference
    {
        public Reference()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string RefDetails { get; set; }
        public string RefThrough { get; set; }
        public string RefAddress { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
