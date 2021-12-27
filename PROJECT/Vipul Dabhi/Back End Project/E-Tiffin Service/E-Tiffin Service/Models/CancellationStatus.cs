using System;
using System.Collections.Generic;

#nullable disable

namespace E_Tiffin_Service.Models
{
    public partial class CancellationStatus
    {
        public int CancellationId { get; set; }
        public int? OrderId { get; set; }
        public DateTime Date { get; set; }
        public bool? Lunch { get; set; }
        public bool? Dinner { get; set; }

        public virtual OrderDetail Order { get; set; }
    }
}
