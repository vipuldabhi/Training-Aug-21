using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tiffin.Models
{
    public partial class CancellationStatus
    {
        [Key]
        public int CancellationId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime CancellationDate { get; set; }

        [Required]
        public int IntervalId { get; set; }

        public bool? Status { get; set; }

        public virtual Interval Interval { get; set; }
        public virtual OrderDetail Order { get; set; }
    }
}
