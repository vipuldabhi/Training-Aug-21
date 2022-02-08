using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class SortByFName : IComparer<DeliveryBoyDto>
    {
        public int Compare(DeliveryBoyDto x, DeliveryBoyDto y)
        {
            return x.FirstName.CompareTo(y.FirstName);
        }
    }

    public class SortByLName : IComparer<DeliveryBoyDto>
    {
        public int Compare(DeliveryBoyDto x, DeliveryBoyDto y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }

    public class DeliveryBoyRepository : GenericRepository<DeliveryBoy>, IDeliveryBoyRepository
    {
        private readonly tiffinContext _tiffinContext;
        private readonly IMapper _mapper;

        public DeliveryBoyRepository(tiffinContext context, IMapper mapper) : base(context)
        {
            _tiffinContext = context;
            _mapper = mapper;
        }


        // sorting method

        public List<DeliveryBoyDto> GetSortedData(int sortid,int refid)
        {
            var result = GetAll();
            var data = result.Where(a => a.IsDeleted == false);

            if (data != null)
            {
                var DtoList = new List<DeliveryBoyDto>();
                foreach (var i in data)
                {
                    var x = _mapper.Map<DeliveryBoyDto>(i);
                    var area = _context.Areas.Find(x.AssignedAreaId);
                    x.AreaName = area.AreaName;
                    DtoList.Add(x);
                }

                if(refid == 3)
                {
                    SortByFName sortByFName = new SortByFName();
                    DtoList.Sort(sortByFName);
                }
                else
                {
                    SortByLName sortByLName = new SortByLName();
                    DtoList.Sort(sortByLName);
                }

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
            var deliveryboy = _tiffinContext.DeliveryBoys.Find(id);
            if (deliveryboy != null && deliveryboy.IsDeleted == false)
            {
                    deliveryboy.IsDeleted = true;
                    _tiffinContext.SaveChanges();
                    return true;
            }
            else
            {
                return false;
            }
        }

    }
}
