﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tiffin.Models
{
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            CancellationStatuses = new HashSet<CancellationStatus>();
            DeliveryStatuses = new HashSet<DeliveryStatus>();
        }

        [Key]
        public int OrderId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int IntervalId { get; set; }

        [Required]
        public int TypeId { get; set; }

        [Required]
        public int DurationId { get; set; }

        [Required]
        public DateTime OrderPlaceDate { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public int AreaId { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PaymentId { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public int TotalCharge { get; set; }

        [Required]
        public int? RestaurantsId { get; set; }

        public virtual Area Area { get; set; }
        public virtual Duration Duration { get; set; }
        public virtual Interval Interval { get; set; }
        public virtual Restaurant Restaurants { get; set; }
        public virtual FoodType Type { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<CancellationStatus> CancellationStatuses { get; set; }
        public virtual ICollection<DeliveryStatus> DeliveryStatuses { get; set; }
    }
}
