using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public interface IOrderDetailRepository : IGenericRepository<OrderDetail>
    {
        List<OrderDetailDto> GetSortedData(int sortid,int refid);
        List<OrderDetailDto> GetOrderOfTheMonth(int month, int year);
        List<OrderDetailDto> GetOrderBetweenGivenDate(DateTime startdate, DateTime enddate);
        List<RevenueFromOrder> GetTotalRevenueFromOrderBetweenGivenDate(DateTime startdate, DateTime enddate);
        List<OrderDetailDto> GetAllOrders();
        OrderDetailDto GetOrderById(int id);
        OrderDetailDto GetOrderByUserId(int id);

    }
}
