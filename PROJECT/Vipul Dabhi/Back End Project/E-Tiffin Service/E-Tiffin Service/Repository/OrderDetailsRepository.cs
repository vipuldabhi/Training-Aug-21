using E_Tiffin_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tiffin_Service.Repository
{
    public class OrderDetailsRepository : GenericRepository<OrderDetail>, IOrderDetailsRepository
    {
        public OrderDetailsRepository(ETiffinContext context) : base(context)
        {
        }

        public override bool Delete(int id)
        {
            var Result = _context.OrderDetails.Find(id);

            if (Result != null && OrderDetail.IsActive == false)
            {
                OrderDetail.IsActive = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
