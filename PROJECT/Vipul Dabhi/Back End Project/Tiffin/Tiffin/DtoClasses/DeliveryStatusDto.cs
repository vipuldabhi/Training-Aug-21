using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiffin.DtoClasses
{
    public class DeliveryStatusDto
    {
        public int DeliveryId { get; set; }
        public int OrderId { get; set; }
        public int IntervalId { get; set; }
        public string IntervalName { get; set; }
        public Boolean Status { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
