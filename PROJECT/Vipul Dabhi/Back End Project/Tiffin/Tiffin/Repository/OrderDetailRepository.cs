using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class SortByOrderDate : IComparer<OrderDetailDto>
    {
        public int Compare(OrderDetailDto x, OrderDetailDto y)
        {
            return x.OrderDate.CompareTo(y.OrderDate);
        }
    }


    public class SortByOrderPlaceDate : IComparer<OrderDetailDto>
    {
        public int Compare(OrderDetailDto x, OrderDetailDto y)
        {
            return x.OrderPlaceDate.CompareTo(y.OrderPlaceDate);
        }
    }


    public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
    {
        private readonly tiffinContext _tiffinContext;
        private readonly IMapper _mapper;

        public OrderDetailRepository(tiffinContext context,IMapper mapper) : base(context)
        {
            _tiffinContext = context;
            _mapper = mapper;
        }


        // sorting method

        public List<OrderDetailDto> GetSortedData(int sortid,int refid)
        {
            
            var result = GetAll();
            var data = result.Where(a => a.IsDeleted == false);

            if (data != null)
            {
                var DtoList = new List<OrderDetailDto>();
                foreach (var i in data)
                {
                    var x = _mapper.Map<OrderDetailDto>(i);
                    var interval = _context.Intervals.FirstOrDefault(a => a.IntervalId == i.IntervalId);
                    var type = _context.FoodTypes.FirstOrDefault(a => a.TypeId == i.TypeId);
                    var duration = _context.Durations.FirstOrDefault(a => a.DurationId == i.DurationId);
                    var area = _context.Areas.FirstOrDefault(a => a.AreaId == i.AreaId);
                    var res = _context.Restaurants.FirstOrDefault(a => a.Id == i.RestaurantsId);
                    x.IntervalName = interval.IntervalName;
                    x.TypeName = type.TypeName;
                    x.DurationTime = duration.DurationTime;
                    x.AreaName = area.AreaName;
                    x.RestaurantName = res.RestaurantName;

                    DtoList.Add(x);
                }

                if(refid == 3)
                {
                    SortByOrderDate sortByOrderDate = new SortByOrderDate();

                    DtoList.Sort(sortByOrderDate);
                }else
                {
                    SortByOrderPlaceDate sortByOrderPlaceDate = new SortByOrderPlaceDate();

                    DtoList.Sort(sortByOrderPlaceDate);
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


        //Get OrderOfTheMonth

        public List<OrderDetailDto> GetOrderOfTheMonth(int month,int year)
        {
            var result = _context.OrderDetails.FromSqlInterpolated<OrderDetail>
                            ($"EXEC OrderOfTheMonth @month={month},@Year={year}").ToList();
            var data = result.Where(a => a.IsDeleted == false);
            if (data.Any())
            {
                var OrderList = new List<OrderDetailDto>();
                foreach (var i in data)
                {
                    var x = _mapper.Map<OrderDetailDto>(i);
                    var interval = _context.Intervals.FirstOrDefault(a => a.IntervalId == i.IntervalId);
                    var type = _context.FoodTypes.FirstOrDefault(a => a.TypeId == i.TypeId);
                    var duration = _context.Durations.FirstOrDefault(a => a.DurationId == i.DurationId);
                    var area = _context.Areas.FirstOrDefault(a => a.AreaId == i.AreaId);
                    var res = _context.Restaurants.FirstOrDefault(a => a.Id == i.RestaurantsId);
                    x.IntervalName = interval.IntervalName;
                    x.TypeName = type.TypeName;
                    x.DurationTime = duration.DurationTime;
                    x.AreaName = area.AreaName;
                    x.RestaurantName = res.RestaurantName;

                    OrderList.Add(x);
                }

                return OrderList;
            }
            else
            {
                return null;
            }
           
        }


        //get Order Between Given Date

        public List<OrderDetailDto> GetOrderBetweenGivenDate(DateTime startdate, DateTime enddate)
        {
            var result = _context.OrderDetails.FromSqlInterpolated<OrderDetail>
                            ($"EXEC OrderBetweenDate @startdate={startdate},@enddate={enddate}").ToList();
            var data = result.Where(a => a.IsDeleted == false);
            if (data.Any())
            {
                var OrderList = new List<OrderDetailDto>();
                foreach (var i in data)
                {
                    var x = _mapper.Map<OrderDetailDto>(i);
                    var interval = _context.Intervals.FirstOrDefault(a => a.IntervalId == i.IntervalId);
                    var type = _context.FoodTypes.FirstOrDefault(a => a.TypeId == i.TypeId);
                    var duration = _context.Durations.FirstOrDefault(a => a.DurationId == i.DurationId);
                    var area = _context.Areas.FirstOrDefault(a => a.AreaId == i.AreaId);
                    var res = _context.Restaurants.FirstOrDefault(a => a.Id == i.RestaurantsId);
                    x.IntervalName = interval.IntervalName;
                    x.TypeName = type.TypeName;
                    x.DurationTime = duration.DurationTime;
                    x.AreaName = area.AreaName;
                    x.RestaurantName = res.RestaurantName;

                    OrderList.Add(x);
                }

                return OrderList;
            }
            else
            {
                return null;
            }
        }


        //get Total Revenue From Order Between Given Date

        public List<RevenueFromOrder> GetTotalRevenueFromOrderBetweenGivenDate(DateTime startdate, DateTime enddate)
        {
            try
            {
                var result = _context.RevenueFromOrder.FromSqlInterpolated<RevenueFromOrder>
                            ($"EXEC TotalRevenueFromOrder @startdate={startdate},@enddate={enddate}").ToList();
                if (result != null)
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            
        }



        public override bool Delete(int id)
        {
            var order = _tiffinContext.OrderDetails.Find(id);
            if (order != null && order.IsDeleted == false)
            {
                order.IsDeleted = true;
                _tiffinContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }




        public List<OrderDetailDto> GetAllOrders()
        {
            var data = _tiffinContext.OrderDetails.Where(a => a.IsDeleted == false);

            if (data.Any())
            {
                var OrderList = new List<OrderDetailDto>();
                foreach (var i in data)
                {
                    var x = _mapper.Map<OrderDetailDto>(i);
                    var interval = _context.Intervals.FirstOrDefault(a => a.IntervalId == i.IntervalId);
                    var type = _context.FoodTypes.FirstOrDefault(a => a.TypeId == i.TypeId);
                    var duration = _context.Durations.FirstOrDefault(a => a.DurationId == i.DurationId);
                    var area = _context.Areas.FirstOrDefault(a => a.AreaId == i.AreaId);
                    var res = _context.Restaurants.FirstOrDefault(a => a.Id == i.RestaurantsId);
                    x.IntervalName = interval.IntervalName;
                    x.TypeName = type.TypeName;
                    x.DurationTime = duration.DurationTime;
                    x.AreaName = area.AreaName;
                    x.RestaurantName = res.RestaurantName;

                    OrderList.Add(x);
                }

                return OrderList;
            }
            else
            {
                return null;
            }
        }
        

        public OrderDetailDto GetOrderById(int id)
        {
            var data = _tiffinContext.OrderDetails.Find(id);

            if (data != null)
            {
                var x = _mapper.Map<OrderDetailDto>(data);
                var interval = _context.Intervals.FirstOrDefault(a => a.IntervalId == data.IntervalId);
                var type = _context.FoodTypes.FirstOrDefault(a => a.TypeId == data.TypeId);
                var duration = _context.Durations.FirstOrDefault(a => a.DurationId == data.DurationId);
                var area = _context.Areas.FirstOrDefault(a => a.AreaId == data.AreaId);
                var res = _context.Restaurants.FirstOrDefault(a => a.Id == data.RestaurantsId);
                x.IntervalName = interval.IntervalName;
                x.TypeName = type.TypeName;
                x.DurationTime = duration.DurationTime;
                x.AreaName = area.AreaName;
                x.RestaurantName = res.RestaurantName;

                return x;
            }
            else
            {
                return null;
            }
        }



        public OrderDetailDto GetOrderByUserId(int id)
        {
            var data = _tiffinContext.OrderDetails.FirstOrDefault(a=>a.UserId == id);

            if (data != null)
            {
                var x = _mapper.Map<OrderDetailDto>(data);
                var interval = _context.Intervals.FirstOrDefault(a => a.IntervalId == data.IntervalId);
                var type = _context.FoodTypes.FirstOrDefault(a => a.TypeId == data.TypeId);
                var duration = _context.Durations.FirstOrDefault(a => a.DurationId == data.DurationId);
                var area = _context.Areas.FirstOrDefault(a => a.AreaId == data.AreaId);
                var res = _context.Restaurants.FirstOrDefault(a => a.Id == data.RestaurantsId);
                x.IntervalName = interval.IntervalName;
                x.TypeName = type.TypeName;
                x.DurationTime = duration.DurationTime;
                x.AreaName = area.AreaName;
                x.RestaurantName = res.RestaurantName;

                return x;
            }
            else
            {
                return null;
            }
        }




        public override bool Create(OrderDetail orderDetail)
        {
            DateTime orderdate = orderDetail.OrderDate;


            if (orderdate > DateTime.Today)
            {
                _tiffinContext.Add(orderDetail);
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
