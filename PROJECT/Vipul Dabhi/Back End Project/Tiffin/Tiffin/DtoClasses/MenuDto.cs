using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiffin.DtoClasses
{
    public class MenuDto
    {
        public int MenuId { get; set; }
        public int DayId { get; set; }
        public int FoodId { get; set; }
        public int IntervalId { get; set; }
        public int RestaurantsId { get; set; }
        public string FoodName { get; set; }
        public string RestaurantName { get; set; }
    }
}
