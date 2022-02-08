using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class DurationRepository : GenericRepository<Duration>, IDurationRepository
    {
        private readonly tiffinContext _tiffinContext;

        public DurationRepository(tiffinContext context) : base(context)
        {
            _tiffinContext = context;
        }

        public override bool Delete(int id)
        {
            var duration = _tiffinContext.Durations.Find(id);
            if (duration != null && duration.IsDeleted == false)
            {
                var data = _tiffinContext.OrderDetails.FirstOrDefault(a => a.DurationId == id);

                if(data == null)
                {
                    duration.IsDeleted = true;
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
