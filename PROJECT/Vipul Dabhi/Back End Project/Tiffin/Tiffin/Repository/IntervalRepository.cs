using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class IntervalRepository : GenericRepository<Interval>, IIntervalRepository
    {
        private readonly tiffinContext _tiffinContext;

        public IntervalRepository(tiffinContext context) : base(context)
        {
            _tiffinContext = context;
        }

        public override bool Delete(int id)
        {
            var interval = _tiffinContext.Intervals.Find(id);
            if (interval != null && interval.IsDeleted == false)
            {
                var data = _tiffinContext.Menus.FirstOrDefault(a => a.IntervalId == id);
                var data1 = _tiffinContext.OrderDetails.FirstOrDefault(a => a.IntervalId == id);

                if (data == null && data1 == null)
                {
                    interval.IsDeleted = true;
                    _tiffinContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
    }
}
