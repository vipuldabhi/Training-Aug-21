using System;
using System.Collections.Generic;

#nullable disable

namespace StudentWebApi.Models
{
    public partial class Emergency
    {
        public int Id { get; set; }
        public string Relation { get; set; }
        public int? Phone { get; set; }

        public virtual Student IdNavigation { get; set; }
    }
}
