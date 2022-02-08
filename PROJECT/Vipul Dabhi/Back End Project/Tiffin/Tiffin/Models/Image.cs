using System;
using System.Collections.Generic;

#nullable disable

namespace Tiffin.Models
{
    public partial class Image
    {
        public int ImageId { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
        public bool IsDeleted { get; set; }
    }
}
