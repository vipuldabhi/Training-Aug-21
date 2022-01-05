using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tiffin.Models
{
    public partial class Menu
    {
        [Key]
        public int MenuId { get; set; }

        [Required]
        public int DayId { get; set; }

        [Required]
        public int FoodId { get; set; }

        [Required]
        public int IntervalId { get; set; }

        public bool? IsDeleted { get; set; }

        public virtual WeekDay Day { get; set; }
        public virtual Food Food { get; set; }
        public virtual Interval Interval { get; set; }
    }
}
