using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LinkedOut.Interface.Repository
{
    public interface IBaseRepository<T>
    {
        Task<T> CreateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<bool> ExistsAsync(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<T> GetAsync(int id);
        Task<T> UpdateAsync(T entity);
    }
}