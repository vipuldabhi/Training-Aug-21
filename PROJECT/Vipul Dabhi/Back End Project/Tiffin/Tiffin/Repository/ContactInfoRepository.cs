using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class ContactInfoRepository : GenericRepository<ContactInfo>, IContactInfoRepository
    {
        private readonly tiffinContext _tiffinContext;

        public ContactInfoRepository(tiffinContext context) : base(context)
        {
            _tiffinContext = context;
        }

        public override bool Delete(int id)
        {
            var contact = _tiffinContext.ContactInfos.Find(id);
            if (contact != null && contact.IsSolved == false)
            {
                contact.IsSolved = true;
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
