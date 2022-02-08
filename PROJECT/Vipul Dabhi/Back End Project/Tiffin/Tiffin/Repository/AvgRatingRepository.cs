using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class SortByAvgRating : IComparer<AvgRatingDto>
    {
        public int Compare(AvgRatingDto x, AvgRatingDto y)
        {
            return x.AvgRating1.CompareTo(y.AvgRating1);
        }
    }

    public class AvgRatingRepository : GenericRepository<AvgRating>, IAvgRatingRepository
    {
        private readonly tiffinContext _tiffinContext;
        private readonly IMapper _mapper;

        public AvgRatingRepository(tiffinContext context, IMapper mapper) : base(context)
        {
            _tiffinContext = context;
            _mapper = mapper;
        }



        // sorting method

        public List<AvgRatingDto> GetSortedData(int sortid)
        {
            var data = GetAll();

            if (data != null)
            {
                var DtoList = new List<AvgRatingDto>();
                foreach (var i in data)
                {
                    var res = _context.Restaurants.Find(i.RestaurantId);
                    var x = _mapper.Map<AvgRatingDto>(i);
                    x.RestaurantName = res.RestaurantName;
                    var area = _context.Areas.Find(res.AreaId);
                    x.AreaName = area.AreaName;
                    DtoList.Add(x);
                }

                SortByAvgRating sortByAvgRating = new SortByAvgRating();

                DtoList.Sort(sortByAvgRating);

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

    }
}
