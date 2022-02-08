using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public interface IContactInfoRepository : IGenericRepository<ContactInfo>
    {
        List<ContactInfoDto> GetSortedData(int sortid);
    }
}
