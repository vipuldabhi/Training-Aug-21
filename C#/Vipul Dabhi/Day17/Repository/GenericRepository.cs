using Day17.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly HospitalContext _context;
        public GenericRepository(HospitalContext context)
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
