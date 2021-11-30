using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        bool Create(T entity);
        bool Update(int id, T entity);
        bool Delete(int id);
        T GetById(int id);

    }
}
