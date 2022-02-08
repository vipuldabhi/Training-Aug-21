using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tiffin.Models
{
    public partial class User
    {
        public User()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Length Should Be 3 to 10 Character Long")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digits are Not Allowed in FirstName!!!")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Length Should Be 3 to 10 Character Long")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digits are Not Allowed in MiddleName!!!")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Length Should Be 3 to 10 Character Long")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digits are Not Allowed in LastName!!!")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Only Digits are Allowed in MobileNo!!!")]
        public string MobileNo { get; set; }

        [Required]
        public int AreaId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10)]
        public string Address { get; set; }

        public bool? IsDeleted { get; set; }

        public virtual Area Area { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }

    }
}
