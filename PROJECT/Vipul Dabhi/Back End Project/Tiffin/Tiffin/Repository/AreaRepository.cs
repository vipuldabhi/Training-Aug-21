using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class AreaRepository : GenericRepository<Area>, IAreaRepository
    {
        private readonly tiffinContext _tiffinContext;

        public AreaRepository(tiffinContext context) : base(context)
        {
            _tiffinContext = context;
        }

        public override bool Delete(int id)
        {
            var area = _tiffinContext.Areas.Find(id);
            if (area != null && area.IsDeleted == false)
            {
                area.IsDeleted = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
