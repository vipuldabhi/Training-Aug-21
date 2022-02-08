using System;
using System.Collections.Generic;

#nullable disable

namespace Tiffin.Models
{
    public partial class DeliveryBoy
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public int AssignedAreaId { get; set; }
        public string Address { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Area AssignedArea { get; set; }
    }
}
