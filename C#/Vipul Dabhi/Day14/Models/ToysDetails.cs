using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Day14.Models
{
    public class ToysDetails
    {
        [Key]
        public int ToyID { get; set; }
        public string ToyName { get; set; }
        public int ToyPrice { get; set; }
        public DateTime ManufactureDate { get; set; }
        public bool IsActive { get; set; }
    }
}
