using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public interface IAreaRepository : IGenericRepository<Area>
    {
        List<AreaDto> GetSortedData(int sortid);

    }
}
