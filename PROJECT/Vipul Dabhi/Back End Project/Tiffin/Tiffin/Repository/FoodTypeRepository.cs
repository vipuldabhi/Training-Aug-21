using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class FoodTypeRepository : GenericRepository<FoodType>, IFoodTypeRepository
    {
        private readonly tiffinContext _tiffinContext;

        public FoodTypeRepository(tiffinContext context) : base(context)
        {
            _tiffinContext = context;
        }

        public override bool Delete(int id)
        {
            var foodType = _tiffinContext.FoodTypes.Find(id);
            if (foodType != null && foodType.IsDeleted == false)
            {
                foodType.IsDeleted = true;
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
