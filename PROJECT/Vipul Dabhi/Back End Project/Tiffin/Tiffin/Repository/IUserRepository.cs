using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        int getUserId(string email);
        UserDto getByEmail(string email);
        List<UserDto> GetSortedData(int sortid, int refid);
    }
}
