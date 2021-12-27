using System;
using System.Collections.Generic;

#nullable disable

namespace E_Tiffin_Service.Models
{
    public partial class CancelledOrder
    {
        public int CancelledOrderId { get; set; }
        public string FullName { get; set; }
        public int CancellationId { get; set; }
        public DateTime Date { get; set; }
        public bool Dinner { get; set; }
        public bool Lunch { get; set; }
    }
}
