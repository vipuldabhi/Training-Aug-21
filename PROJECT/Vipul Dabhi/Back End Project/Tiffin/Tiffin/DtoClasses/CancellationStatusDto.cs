using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiffin.DtoClasses
{
    public class CancellationStatusDto
    {
        public int CancellationId { get; set; }
        public int OrderId { get; set; }
        public DateTime CancellationDate { get; set; }
        public int IntervalId { get; set; }
        public string  IntervalName { get; set; }

    }
}
