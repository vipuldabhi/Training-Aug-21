using System;
using System.Collections.Generic;

#nullable disable

namespace Tiffin.Models
{
    public partial class DeliveryCharge
    {
        public int Id { get; set; }
        public int DurationId { get; set; }
        public int Charge { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Duration Duration { get; set; }
    }
}
