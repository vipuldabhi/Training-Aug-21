using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public interface IRestaurantRepository : IGenericRepository<Restaurant>
    {
        List<RestaurantsDto> GetSortedData(int sortid);
    }
}
