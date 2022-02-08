using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class DeliveryChargesRepository : GenericRepository<DeliveryCharge>, IDeliveryChargesRepository
    {
        private readonly tiffinContext _tiffinContext;

        public DeliveryChargesRepository(tiffinContext context) : base(context)
        {
            _tiffinContext = context;
        }


        //delete method

        public override bool Delete(int id)
        {
            var charge = _tiffinContext.DeliveryCharges.Find(id);
            if (charge != null && charge.IsDeleted == false)
            {
                var data = _tiffinContext.OrderDetails.FirstOrDefault(a=>a.DurationId == charge.DurationId);
                var data1 = _context.Durations.FirstOrDefault(a => a.DurationId == charge.DurationId);

                if (data == null && data1 == null)
                {
                    charge.IsDeleted = true;
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
