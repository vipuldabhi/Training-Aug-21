using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiffin.DtoClasses
{
    public class RatingDto
    {
        public int RatindId { get; set; }
        public int RestaurantId { get; set; }
        public string  RestaurantName { get; set; }
        public int UserId { get; set; }
        public double Rating1 { get; set; }

    }
}
