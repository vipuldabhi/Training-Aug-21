using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiffin.DtoClasses
{
    public class OrderDetailDto
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int IntervalId { get; set; }
        public string IntervalName { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int DurationId { get; set; }
        public string DurationTime { get; set; }
        public DateTime OrderPlaceDate { get; set; }
        public DateTime OrderDate { get; set; }
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public string Address { get; set; }
        public string PaymentId { get; set; }
        public int TotalCharge { get; set; }
        public int RestaurantsId { get; set; }
        public string RestaurantName { get; set; }

    }
}
