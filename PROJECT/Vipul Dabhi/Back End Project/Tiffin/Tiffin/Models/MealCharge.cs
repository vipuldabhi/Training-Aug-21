using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tiffin.Models
{
    public partial class MealCharge
    {
        [Key]
        public int ChargeId { get; set; }

        [Required]
        public int? IntervalId { get; set; }

        [Required]
        //[RegularExpression(@"^([0-9])$", ErrorMessage = "Alphabets are Not Allowed!!!")]
        public int Charge { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public int? RestaurantsId { get; set; }

        public virtual Interval Interval { get; set; }
        public virtual Restaurant Restaurants { get; set; }
    }
}
