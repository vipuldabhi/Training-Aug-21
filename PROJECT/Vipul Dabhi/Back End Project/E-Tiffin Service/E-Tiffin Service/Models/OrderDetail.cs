using System;
using System.Collections.Generic;

#nullable disable

namespace E_Tiffin_Service.Models
{
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            CancellationStatuses = new HashSet<CancellationStatus>();
            PaymentStatuses = new HashSet<PaymentStatus>();
        }

        public int OrderId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Area { get; set; }
        public string TiffinTime { get; set; }
        public string TiffinType { get; set; }
        public string TiffinPlan { get; set; }
        public int Extra { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }

        public virtual DeliveryStatus DeliveryStatus { get; set; }
        public virtual ICollection<CancellationStatus> CancellationStatuses { get; set; }
        public virtual ICollection<PaymentStatus> PaymentStatuses { get; set; }
    }
}
