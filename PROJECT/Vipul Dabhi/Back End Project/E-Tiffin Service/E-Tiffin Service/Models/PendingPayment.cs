using System;
using System.Collections.Generic;

#nullable disable

namespace E_Tiffin_Service.Models
{
    public partial class PendingPayment
    {
        public int OrderId { get; set; }
        public string FullName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }
        public int PaymentId { get; set; }
        public bool Status { get; set; }
    }
}
