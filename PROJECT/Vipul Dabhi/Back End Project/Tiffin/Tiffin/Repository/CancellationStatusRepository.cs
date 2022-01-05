using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class CancellationStatusRepository : GenericRepository<CancellationStatus>, ICancellationStatusRepository
    {
        public CancellationStatusRepository(tiffinContext context) : base(context)
        {
        }
    }
}
