using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class WeekDayRepository : GenericRepository<WeekDay>, IWeekDayRepository
    {
        private readonly tiffinContext _tiffinContext;

        public WeekDayRepository(tiffinContext context) : base(context)
        {
            _tiffinContext = context;
        }

        public override bool Delete(int id)
        {
            var weekDay = _tiffinContext.WeekDays.Find(id);
            if (weekDay != null && weekDay.IsDeleted == false)
            {

                var data = _tiffinContext.Menus.FirstOrDefault(a => a.DayId == id);

                if(data == null)
                {
                    weekDay.IsDeleted = true;
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
