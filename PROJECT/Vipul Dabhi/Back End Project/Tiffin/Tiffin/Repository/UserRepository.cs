using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class SortByFirstName : IComparer<UserDto>
    {
        public int Compare(UserDto x, UserDto y)
        {
            return x.FirstName.CompareTo(y.FirstName);
        }
    }


    public class SortByLastName : IComparer<UserDto>
    {
        public int Compare(UserDto x, UserDto y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }

    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly tiffinContext _tiffinContext;
        private readonly IMapper _mapper;

        public UserRepository(tiffinContext context,IMapper mapper) : base(context)
        {
            _tiffinContext = context;
            _mapper = mapper;
        }

        public int getUserId(string email)
        {
            var user = _tiffinContext.Users.FirstOrDefault(a => a.Email == email);
            if (user != null)
            {
                int UserId = user.UserId;

                return UserId;
            }
            else
            {
                return 0;
            }
        }

        public UserDto getByEmail(string email)
        {
            var user = _tiffinContext.Users.FirstOrDefault(a => a.Email == email);
            if(user != null)
            {
                var x = _mapper.Map<UserDto>(user);
                var area = _tiffinContext.Areas.FirstOrDefault(a => a.AreaId == x.AreaId);
                x.AreaName = area.AreaName;

                return x;
            }
            else
            {
                return null;
            }
        }



        // sorting method

        public List<UserDto> GetSortedData(int sortid, int refid)
        {

            var result = GetAll();
            var data = result.Where(a => a.IsDeleted == false);

            if (data != null)
            {
                var DtoList = new List<UserDto>();
                foreach (var i in data)
                {
                    var x = _mapper.Map<UserDto>(i);
                    var area = _context.Areas.FirstOrDefault(a => a.AreaId == i.AreaId);
                    x.AreaName = area.AreaName;
                    DtoList.Add(x);
                }

                if (refid == 3)
                {
                    SortByFirstName sortByFirstName = new SortByFirstName();

                    DtoList.Sort(sortByFirstName);
                }
                else
                {
                    SortByLastName sortByLastName = new SortByLastName();

                    DtoList.Sort(sortByLastName);
                }


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
            var user = _tiffinContext.Users.Find(id);
            if (user != null && user.IsDeleted == false)
            {
                var data = _tiffinContext.OrderDetails.FirstOrDefault(a => a.UserId == id);

                if(data == null)
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
            else
            {
                return false;
            }
        }
    }
}
