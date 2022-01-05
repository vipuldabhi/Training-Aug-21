using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class DayWiseMenuRepository : GenericRepository<DayWiseMenu>, IDayWiseMenuRepository
    {
        public DayWiseMenuRepository(tiffinContext context) : base(context)
        {
        }
    }
}
