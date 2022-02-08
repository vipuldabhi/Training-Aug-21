using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public interface IMealChargesRepository : IGenericRepository<MealCharge>
    {
        List<MealChargesDto> GetSortedData(int intervalid,int flag);
        int getCharge(int resid, int intervalid);
    }
}
