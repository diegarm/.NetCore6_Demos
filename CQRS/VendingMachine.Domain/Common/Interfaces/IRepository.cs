using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Domain.Common.Interfaces
{
    public interface IRepository<T>
    {
        Task SaveAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        Task<T> GetAsync(object id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllByCriteria(Expression<Func<T, bool>> expression);

        Task<T> GetOneByCriteria(Expression<Func<T, bool>> expression);

    }
}
