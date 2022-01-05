using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tiffin.Models
{
    public partial class WeekDay
    {
        public WeekDay()
        {
            Menus = new HashSet<Menu>();
        }

        [Key]
        public int DayId { get; set; }

        [Required]
        [StringLength(9,MinimumLength =6,ErrorMessage = "Length Should Be 6 to 9 Character Long")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Digits are Not Allowed in WeekDayName!!!")]
        public string WeekDayName { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
    }
}
