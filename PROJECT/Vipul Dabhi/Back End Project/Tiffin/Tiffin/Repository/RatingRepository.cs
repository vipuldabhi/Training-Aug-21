using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.DtoClasses;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class RatingRepository : GenericRepository<Rating>, IRatingRepository
    {
        private readonly tiffinContext _tiffinContext;

        public RatingRepository(tiffinContext context) : base(context)
        {
            _tiffinContext = context;
        }



        public override bool Delete(int id)
        {
            var data = _tiffinContext.Ratings.Find(id);
            if (data != null && data.IsDeleted == false)
            {
                data.IsDeleted = true;
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
