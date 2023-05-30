using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Movie_eTickets.Data.Base
{
    public interface IEntityBaseRepository<T> where T: class, IEntityBase, new()
    {
        // Get All Data
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        // Get Data by ID
        Task<T> GetByIdAsync(int id);
        // Add Data to Database
        Task AddAsync(T entity);
        // Update Data to Database
        Task UpdateAsync(int id, T entity);
        // Delete Data from Database
        Task DeleteAsync(int id);
    }
}
