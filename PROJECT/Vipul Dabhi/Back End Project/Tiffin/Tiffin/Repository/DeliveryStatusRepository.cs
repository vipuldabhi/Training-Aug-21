using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class DeliveryStatusRepository : GenericRepository<DeliveryStatus>, IDeliveryStatusRepository
    {
        private readonly tiffinContext _tiffinContext;

        public DeliveryStatusRepository(tiffinContext context) : base(context)
        {
            _tiffinContext = context;
        }

        public override bool Delete(int id)
        {
            var data = _tiffinContext.DeliveryStatuses.Find(id);
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
    }
}
