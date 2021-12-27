using E_Tiffin_Service.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tiffin_Service.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ETiffinContext _context;
        public GenericRepository(ETiffinContext context)
        {
            _context = context;
        }

        public virtual bool Create(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
            return true;
        }

        public virtual bool Delete(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public virtual bool Update(int id, T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

    }
}
