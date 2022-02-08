using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tiffin.Models
{
    public partial class Duration
    {
        public Duration()
        {
            DeliveryCharges = new HashSet<DeliveryCharge>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        public int DurationId { get; set; }

        [Required]
        public string DurationTime { get; set; }

        public bool? IsDeleted { get; set; }

        public virtual ICollection<DeliveryCharge> DeliveryCharges { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
