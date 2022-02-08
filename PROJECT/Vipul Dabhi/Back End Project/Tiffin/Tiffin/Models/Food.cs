using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tiffin.Models
{
    public partial class Food
    {
        public Food()
        {
            Menus = new HashSet<Menu>();
        }

        [Key]
        public int FoodId { get; set; }

        [Required]
        [StringLength(9, MinimumLength = 3, ErrorMessage = "Length Should Be 3 to 9 Character Long")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Digits are Not Allowed in IntervalName!!!")]
        public string FoodName { get; set; }

        public bool? IsDeleted { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
    }
}
