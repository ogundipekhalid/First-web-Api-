using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LinkedOut.Context;
using LinkedOut.Interface.Repository;
using Microsoft.EntityFrameworkCore;

namespace LinkedOut.Implementations.Repository
{
   public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        protected ApplicationContext _Context;
        public async Task<T> CreateAsync(T entity)
        {
            await _Context.Set<T>().AddAsync(entity);
            await _Context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _Context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression)
        {
            return await _Context.Set<T>().Where(expression).ToListAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _Context.Set<T>().Update(entity);
            await _Context.SaveChangesAsync();
            return entity;
        }
        public async Task<bool> DeleteAsync(T entity)
        {
            _Context.Set<T>().Remove(entity);
          await  _Context.SaveChangesAsync();
            return true;
        }
        public async Task<T> GetAsync(int id)
        {
            return await _Context.Set<T>().FindAsync(id);
        }
        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return await _Context.Set<T>().SingleOrDefaultAsync(expression);
        }
        public async Task<bool> ExistsAsync(Expression<Func<T, bool>> expression)
        {
            return await _Context.Set<T>().AnyAsync(expression);
        }
    }
}