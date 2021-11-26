using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Day14.Models
{
    public class ToyCatageory
    {
        [Key]
        public int CatageoryID { get; set; }
        public string CategeoryName { get; set; }
        public bool IsActive { get; set; }
    }
}
