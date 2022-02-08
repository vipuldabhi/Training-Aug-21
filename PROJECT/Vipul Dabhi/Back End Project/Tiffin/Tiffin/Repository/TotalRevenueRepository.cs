using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class TotalRevenueRepository : GenericRepository<TotalRevenue>, ITotalRevenueRepository
    {
        private readonly tiffinContext _tiffinContext;

        public TotalRevenueRepository(tiffinContext context) : base(context)
        {
            _tiffinContext = context;
        }
    }
}
