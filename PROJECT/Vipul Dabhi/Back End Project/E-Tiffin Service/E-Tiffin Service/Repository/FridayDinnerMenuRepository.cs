using E_Tiffin_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tiffin_Service.Repository
{
    public class FridayDinnerMenuRepository : GenericRepository<FridayDinnerMenu>, IFridayDinnerMenuRepository
    {
        public FridayDinnerMenuRepository(ETiffinContext context) : base(context)
        {
        }
    }
}
