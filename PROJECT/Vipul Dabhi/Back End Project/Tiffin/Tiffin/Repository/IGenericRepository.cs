using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiffin.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(int id);
        T GetById(int id);
    }
}
