using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly tiffinContext _tiffinContext;

        public UserRepository(tiffinContext context) : base(context)
        {
            _tiffinContext = context;
        }

        public override bool Delete(int id)
        {
            var user = _tiffinContext.Users.Find(id);
            if (user != null && user.IsDeleted == false)
            {
                user.IsDeleted = true;
                _tiffinContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
