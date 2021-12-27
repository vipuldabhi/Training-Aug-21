using E_Tiffin_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tiffin_Service.Repository
{
    public class PendingPaymentRepository : GenericRepository<PendingPayment>, IPendingPaymentRepository
    {
        public PendingPaymentRepository(ETiffinContext context) : base(context)
        {
        }

    }
}
