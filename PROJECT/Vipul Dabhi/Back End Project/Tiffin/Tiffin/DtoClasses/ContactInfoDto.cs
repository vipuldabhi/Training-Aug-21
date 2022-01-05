using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiffin.DtoClasses
{
    public class ContactInfoDto
    {
        public int ContactId { get; set; }
        public string FullName { get; set; }
        public string Email{ get; set; }
        public string ContactNo { get; set; }
        public string Subject { get; set; }

    }
}
