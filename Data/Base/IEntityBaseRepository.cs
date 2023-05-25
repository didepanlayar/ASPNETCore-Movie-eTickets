using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movie_eTickets.Data.Base
{
    public interface IEntityBaseRepository<T> where T: class, IEntityBase, new()
    {
        // Get All Data
        Task<IEnumerable<T>> GetAllAsync();
        // Get Data by ID
        Task<T> GetByIdAsync(int id);
        // Add Data to Database
        Task AddAsync(T entity);
        // Update Data to Database
        Task<T> UpdateAsync(int id, T entity);
        // Delete Data from Database
        Task DeleteAsync(int id);
    }
}
