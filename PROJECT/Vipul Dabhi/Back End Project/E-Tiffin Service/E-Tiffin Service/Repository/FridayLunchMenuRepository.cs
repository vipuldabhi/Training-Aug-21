using E_Tiffin_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tiffin_Service.Repository
{
    public class FridayLunchMenuRepository : GenericRepository<FridayLunchMenu>, IFridayLunchMenuRepository
    {
        public FridayLunchMenuRepository(ETiffinContext context) : base(context)
        {
        }
    }
}
