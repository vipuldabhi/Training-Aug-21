using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tiffin.Entities
{
    public class SignUpModel
    {
        [Required]
        [StringLength(9, MinimumLength = 3, ErrorMessage = "Length Should Be 3 to 9 Character Long")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digits are Not Allowed in IntervalName!!!")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(9, MinimumLength = 3, ErrorMessage = "Length Should Be 3 to 9 Character Long")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digits are Not Allowed in IntervalName!!!")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Compare("ConfirmPassword")]
        [StringLength(50, MinimumLength = 8)]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }
    }
}
