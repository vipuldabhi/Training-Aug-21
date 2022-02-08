using System;
using System.Collections.Generic;

#nullable disable
    
namespace Tiffin.Models
{
    public partial class DayWiseMenu
    {
        public int DayId { get; set; }
        public string WeekDayName { get; set; }
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public int IntervalId { get; set; }
        public string IntervalName { get; set; }
        public int Id { get; set; }  
        public string RestaurantName { get; set; }
    }
}
       