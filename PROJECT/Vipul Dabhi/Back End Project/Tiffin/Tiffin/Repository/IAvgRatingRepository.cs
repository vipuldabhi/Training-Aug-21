using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public interface IAvgRatingRepository : IGenericRepository<AvgRating>
    {
        List<AvgRatingDto> GetSortedData(int sortid);
    }
}
