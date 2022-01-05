using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tiffin.Models
{
    public partial class ContactInfo
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "ContactNo Must 10 Digit Long & Alphabets are Not Allowed!!!")]
        public string ContactNo { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10)]
        public string Subject { get; set; }

        public bool? IsSolved { get; set; }
    }
}
