using E_Tiffin_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tiffin_Service.Repository
{
    public class TuesdayLunchMenuRepository : GenericRepository<TuesdayLunchMenu>, ITuesdayLunchMenuRepository
    {
        public TuesdayLunchMenuRepository(ETiffinContext context) : base(context)
        {
        }
    }
}
