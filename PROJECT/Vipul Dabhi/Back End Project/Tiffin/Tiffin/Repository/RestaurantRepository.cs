using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class SortByRestaurantName : IComparer<RestaurantsDto>
    {
        public int Compare(RestaurantsDto x, RestaurantsDto y)
        {
            return x.RestaurantName.CompareTo(y.RestaurantName);
        }
    }

    public class RestaurantRepository : GenericRepository<Restaurant>, IRestaurantRepository
    {
        private readonly tiffinContext _tiffinContext;
        private readonly IMapper _mapper;

        public RestaurantRepository(tiffinContext context,IMapper mapper) : base(context)
        {
            _tiffinContext = context;
            _mapper = mapper;
        }



        // sorting method

        public List<RestaurantsDto> GetSortedData(int sortid)
        {
            var result = GetAll();
            var data = result.Where(a => a.IsDeleted == false);
            if (data != null)
            {
                var DtoList = new List<RestaurantsDto>();
                foreach (var i in data)
                {
                    var x = _mapper.Map<RestaurantsDto>(i);
                    var area = _context.Areas.Find(i.AreaId);
                    x.AreaName = area.AreaName;
                    DtoList.Add(x);
                }

                SortByRestaurantName sortByRestaurantName = new SortByRestaurantName();

                DtoList.Sort(sortByRestaurantName);

                if (sortid == 1)
                {
                    return DtoList;
                }
                else
                {
                    DtoList.Reverse();
                    return DtoList;
                }
            }
            else
            {
                return null;
            }

        }


        public override bool Delete(int id)
        {
            var restaurant = _tiffinContext.Restaurants.Find(id);
            if (restaurant != null && restaurant.IsDeleted == false)
            {
                var data = _tiffinContext.Menus.FirstOrDefault(a => a.RestaurantsId == id);
                var data1 = _tiffinContext.OrderDetails.FirstOrDefault(a => a.RestaurantsId == id);


                if (data == null && data1 == null)
                {
                    restaurant.IsDeleted = true;
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
