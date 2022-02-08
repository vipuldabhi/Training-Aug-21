using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class SortByCancellationDate : IComparer<CancellationStatusDto>
    {
        public int Compare(CancellationStatusDto x, CancellationStatusDto y)
        {
            return x.CancellationDate.CompareTo(y.CancellationDate);
        }
    }


    public class CancellationStatusRepository : GenericRepository<CancellationStatus>, ICancellationStatusRepository
    {
        private readonly tiffinContext _tiffinContext;
        private readonly IMapper _mapper;

        public CancellationStatusRepository(tiffinContext context,IMapper mapper) : base(context)
        {
            _tiffinContext = context;
            _mapper = mapper;
        }



        // sorting method

        public List<CancellationStatusDto> GetSortedData(int sortid)
        {
            var result = GetAll();
            var data = result.Where(a => a.IsDeleted == false);

            if (data != null)
            {
                var DtoList = new List<CancellationStatusDto>();
                foreach (var i in data)
                {
                    var x = _mapper.Map<CancellationStatusDto>(i);
                    var interval = _context.Intervals.FirstOrDefault(a => a.IntervalId == x.IntervalId);
                    x.IntervalName = interval.IntervalName;
                    DtoList.Add(x);
                }

                SortByCancellationDate sortByCancellationDate = new SortByCancellationDate();

                DtoList.Sort(sortByCancellationDate);

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
            var data = _tiffinContext.CancellationStatuses.Find(id);
            if (data != null && data.IsDeleted == false)
            {
                data.IsDeleted = true;
                _tiffinContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Create(CancellationStatus cancellationStatus)
        {
            DateTime date = cancellationStatus.CancellationDate;

            int orderId = cancellationStatus.OrderId;
            var order = _tiffinContext.OrderDetails.Find(orderId);

            DateTime orderdate = order.OrderDate;

            int durationId = order.DurationId;
            int interval = order.IntervalId;
            int days = 0;

            if(durationId == 1)
            {
                days = 1;
            }else if (durationId == 2)
            {
                days = 7;                      
            }else if (durationId == 3)
            {
                days = 30;
            }else if(durationId == 4)
            {
                days = 90;
            }

            DateTime expiryDate = orderdate.AddDays(days);

            //check if cancellationDate is not valid than return false

            if (date > DateTime.Today && date < expiryDate && cancellationStatus.IntervalId == interval)
            {
                _tiffinContext.Add(cancellationStatus);
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
