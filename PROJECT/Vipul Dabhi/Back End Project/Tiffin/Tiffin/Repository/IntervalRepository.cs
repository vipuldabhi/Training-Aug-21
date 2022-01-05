using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class IntervalRepository : GenericRepository<Interval>, IIntervalRepository
    {
        public IntervalRepository(tiffinContext context) : base(context)
        {
        }
    }
}
