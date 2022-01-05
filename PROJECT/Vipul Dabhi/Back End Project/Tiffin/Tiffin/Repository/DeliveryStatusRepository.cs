using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class DeliveryStatusRepository : GenericRepository<DeliveryStatus>, IDeliveryStatusRepository
    {
        public DeliveryStatusRepository(tiffinContext context) : base(context)
        {
        }
    }
}
