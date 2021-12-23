using System;
using System.Collections.Generic;

#nullable disable

namespace StudentApi.Models
{
    public partial class Emergency
    {
        public int Id { get; set; }
        public string Relation { get; set; }
        public string Phone { get; set; }
        public int? StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
