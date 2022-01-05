using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tiffin.Models
{
    public partial class FoodType
    {
        public FoodType()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        public int TypeId { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Length Should Be 3 to 9 Character Long")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digits are Not Allowed in IntervalName!!!")]
        public string TypeName { get; set; }

        public bool? IsDeleted { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
