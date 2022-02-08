using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tiffin.Models
{
    public partial class Interval
    {
        public Interval()
        {
            CancellationStatuses = new HashSet<CancellationStatus>();
            DeliveryStatuses = new HashSet<DeliveryStatus>();
            MealCharges = new HashSet<MealCharge>();
            Menus = new HashSet<Menu>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        public int IntervalId { get; set; }

        [Required]
        [StringLength(9, MinimumLength = 3, ErrorMessage = "Length Should Be 3 to 9 Character Long")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digits are Not Allowed in IntervalName!!!")]
        public string IntervalName { get; set; }

        public bool? IsDeleted { get; set; }

        public virtual ICollection<CancellationStatus> CancellationStatuses { get; set; }
        public virtual ICollection<DeliveryStatus> DeliveryStatuses { get; set; }
        public virtual ICollection<MealCharge> MealCharges { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
