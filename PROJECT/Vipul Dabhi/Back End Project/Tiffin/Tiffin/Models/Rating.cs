using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tiffin.Models
{
    public partial class Rating
    {
        [Key]
        public int RatindId { get; set; }

        [Required]
        public int RestaurantId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [RegularExpression(@"^[0-9.]+$", ErrorMessage = "Aplphabets are Not Allowed in Rating!!!")]
        public double Rating1 { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public virtual User User { get; set; }
    }
}
