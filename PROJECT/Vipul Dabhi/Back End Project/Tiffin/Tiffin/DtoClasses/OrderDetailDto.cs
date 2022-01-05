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
        public int TypeId { get; set; }
        public int DurationId { get; set; }
        public DateTime OrderPlaceDate { get; set; }
        public DateTime OrderDate { get; set; }
        public int AreaId { get; set; }
        public string Address { get; set; }
        public string PaymentId { get; set; }



    }
}
