using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class SortByName : IComparer<ContactInfoDto>
    {
        public int Compare(ContactInfoDto x, ContactInfoDto y)
        {
            return x.FullName.CompareTo(y.FullName);
        }
    }

    public class ContactInfoRepository : GenericRepository<ContactInfo>, IContactInfoRepository
    {
        private readonly tiffinContext _tiffinContext;
        private readonly IMapper _mapper;

        public ContactInfoRepository(tiffinContext context,IMapper mapper) : base(context)
        {
            _tiffinContext = context;
            _mapper = mapper;
        }


        // sorting method

        public List<ContactInfoDto> GetSortedData(int sortid)
        {
            var result = GetAll();
            var data = result.Where(a => a.IsSolved == false);

            if (data != null)
            {
                var DtoList = new List<ContactInfoDto>();
                foreach (var i in data)
                {
                    DtoList.Add(_mapper.Map<ContactInfoDto>(i));
                }

                SortByName sortByName = new SortByName();

                DtoList.Sort(sortByName);

                if (sortid == 1)
                {
                    return DtoList;
                }
                else
                {
                    DtoList.Reverse();
                    return DtoList;
                }
            }
            else
            {
                return null;
            }

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
