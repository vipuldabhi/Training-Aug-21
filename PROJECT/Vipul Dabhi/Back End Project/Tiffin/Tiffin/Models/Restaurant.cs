using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tiffin.Models
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            MealCharges = new HashSet<MealCharge>();
            Menus = new HashSet<Menu>();
            OrderDetails = new HashSet<OrderDetail>();
            Ratings = new HashSet<Rating>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string RestaurantName { get; set; }

        [Required]
        public bool? IsDeleted { get; set; }

        [Required]
        public int AreaId { get; set; }

        public virtual Area Area { get; set; }
        public virtual ICollection<MealCharge> MealCharges { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
