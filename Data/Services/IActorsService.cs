using Movie_eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movie_eTickets.Data.Services
{
    public interface IActorsService
    {
        // Get All Actor
        Task<IEnumerable<Actor>> GetAllAsync();
        // Get Actor by ID
        Task<Actor> GetByIdAsync(int id);
        // Add Actor to Database
        Task AddAsync(Actor actor);
        // Update Actor to Database
        Actor Update(int id, Actor newActor);
        // Delete Actor from Database
        void Delete(int id);
    }
}
