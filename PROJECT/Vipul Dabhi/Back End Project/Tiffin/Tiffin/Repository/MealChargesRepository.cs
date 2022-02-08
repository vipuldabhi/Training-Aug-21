using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class SortByMealCharges : IComparer<MealChargesDto>
    {
        public int Compare(MealChargesDto x, MealChargesDto y)
        {
            return x.Charge.CompareTo(y.Charge);
        }
    }

    public class MealChargesRepository : GenericRepository<MealCharge>, IMealChargesRepository
    {
        private readonly tiffinContext _tiffinContext;
        private readonly IMapper _mapper;

        public MealChargesRepository(tiffinContext context,IMapper mapper) : base(context)
        {
            _tiffinContext = context;
            _mapper = mapper;
        }



        // sorting method

        public List<MealChargesDto> GetSortedData(int sortid,int intervalid)
        {
            var data = GetAll().Where(a => a.IntervalId == intervalid);

            if(data != null)
            {
                var DtoList = new List<MealChargesDto>();
                foreach (var i in data)
                {
                    var dto = _mapper.Map<MealChargesDto>(i);
                    var restaurant = _context.Restaurants.Find(dto.RestaurantsId);
                    dto.RestaurantName = restaurant.RestaurantName;
                    var interval = _context.Intervals.Find(dto.IntervalId);
                    dto.IntervalName = interval.IntervalName;
                    DtoList.Add(dto);
                }

                SortByMealCharges sortByMealCharges = new SortByMealCharges();

                DtoList.Sort(sortByMealCharges);

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



        public int getCharge(int resid,int intervalid)
        {
            //Match Data With Provided Id Into Url
            var data = _context.MealCharges.FirstOrDefault(a => a.RestaurantsId == resid && a.IntervalId == intervalid);
            
            if (data != null && data.IsDeleted == false)
            {
                int charge = data.Charge;
                return charge;
            }
            else
            {
                return 0;
            }
        }





        public override bool Delete(int id)
        {
            var charges = _tiffinContext.MealCharges.Find(id);
            if (charges != null && charges.IsDeleted == false)
            {
                charges.IsDeleted = true;
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
