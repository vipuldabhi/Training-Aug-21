using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiffin.Models;

namespace Tiffin.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
{
        protected readonly tiffinContext _context;
        public GenericRepository(tiffinContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual bool Create(T entity)
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
           
        }

        public virtual bool Update(T entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public virtual bool Delete(int id)
        {
            var data = _context.Set<T>().Find(id);
            _context.Remove(data);
            _context.SaveChanges();
            return true;
        }   

    }
}
