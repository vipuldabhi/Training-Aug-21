using System;
using System.Collections.Generic;

#nullable disable

namespace Tiffin.Models
{
    public partial class DeliveryStatus
    {
        public int DeliveryId { get; set; }
        public int OrderId { get; set; }
        public int IntervalId { get; set; }
        public bool? Status { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeliveryDate { get; set; }

        public virtual Interval Interval { get; set; }
        public virtual OrderDetail Order { get; set; }
    }
}
