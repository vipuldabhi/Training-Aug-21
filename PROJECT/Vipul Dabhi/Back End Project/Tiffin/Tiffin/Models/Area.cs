using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tiffin.Models
{
    public partial class Area
    {
        public Area()
        {
            OrderDetails = new HashSet<OrderDetail>();
            Users = new HashSet<User>();
        }

        [Key]
        public int AreaId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string AreaName { get; set; }

        public bool? IsDeleted { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
