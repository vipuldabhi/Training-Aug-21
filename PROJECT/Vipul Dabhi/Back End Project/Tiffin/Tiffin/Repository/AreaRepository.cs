using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;
using Newtonsoft.Json;
using System.Collections;
using AutoMapper;

namespace Tiffin.Repository
{
    public class SortByAreaName : IComparer<AreaDto>
    {
        public int Compare(AreaDto x,AreaDto y)
        {
            return x.AreaName.CompareTo(y.AreaName);
        }
    }

    public class AreaRepository : GenericRepository<Area>, IAreaRepository
    {
        private readonly tiffinContext _tiffinContext;
        private readonly IMapper _mapper;

        public AreaRepository(tiffinContext context,IMapper mapper) : base(context)
        {
            _tiffinContext = context;
            _mapper = mapper;
        }


        // sorting method

        public List<AreaDto> GetSortedData(int sortid)
        {
            var result = GetAll();
            var data = result.Where(a => a.IsDeleted == false);
            if (data != null)
            {
                var DtoList = new List<AreaDto>();
                foreach (var i in data)
                {
                    DtoList.Add(_mapper.Map<AreaDto>(i));
                }

                SortByAreaName sortByAreaName = new SortByAreaName();

                DtoList.Sort(sortByAreaName);

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




        //delete method

        public override bool Delete(int id)
        {
            var area = _tiffinContext.Areas.Find(id);
            if (area != null && area.IsDeleted == false)
            {
                var data = _tiffinContext.OrderDetails.FirstOrDefault(a=>a.AreaId == area.AreaId);

                if(data == null)
                {
                    area.IsDeleted = true;
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
