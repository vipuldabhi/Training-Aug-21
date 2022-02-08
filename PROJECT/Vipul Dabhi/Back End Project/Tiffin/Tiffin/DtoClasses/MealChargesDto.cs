using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiffin.DtoClasses
{
    public class MealChargesDto
    {
        public int ChargeId { get; set; }
        public int RestaurantsId { get; set; }
        public int IntervalId { get; set; }
        public int Charge { get; set; }
        public string RestaurantName { get; set; }
        public string IntervalName { get; set; }



    }
}
