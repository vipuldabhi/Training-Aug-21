using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class FoodRepository : GenericRepository<Food>, IFoodRepository
    {
        private readonly tiffinContext _tiffinContext;

        public FoodRepository(tiffinContext context) : base(context)
        {
            _tiffinContext = context;
        }

        public override bool Delete(int id)
        {
            var food = _tiffinContext.Foods.Find(id);
            if (food != null && food.IsDeleted == false)
            {
                var data = _tiffinContext.Menus.FirstOrDefault(a => a.FoodId == id);

                if (data == null)
                {
                    food.IsDeleted = true;
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
