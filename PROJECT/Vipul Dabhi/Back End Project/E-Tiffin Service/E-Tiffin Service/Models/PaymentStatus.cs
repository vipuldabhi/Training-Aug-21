using System;
using System.Collections.Generic;

#nullable disable

namespace E_Tiffin_Service.Models
{
    public partial class PaymentStatus
    {
        public int PaymentId { get; set; }
        public int? OrderId { get; set; }
        public bool Status { get; set; }

        public virtual OrderDetail Order { get; set; }
    }
}
