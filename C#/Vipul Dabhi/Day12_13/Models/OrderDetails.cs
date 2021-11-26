using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Day12_13.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderID { get; set; }
        public ICollection<CustomerDetails> Customers { get; set; }
        public ICollection<ToysDetails> Toys { get; set; }
        public bool IsActive { get; set; }



    }
}
