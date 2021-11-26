using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Day12_13.Models
{
    public class PlantsDetails
    {
        [Key]
        public int PlantID { get; set; }
        public string PlantName { get; set; }
        public string PlantAddress { get; set; }
        public bool IsActive { get; set; }
        public ICollection<ToysDetails> Toys { get; set; }
        public ICollection<ToyCatageory> Catageories { get; set; }
    }
}
