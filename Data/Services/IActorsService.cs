using Movie_eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movie_eTickets.Data.Services
{
    public interface IActorsService
    {
        // Get All Actor
        Task<IEnumerable<Actor>> GetAll();
        // Get Actor by ID
        Actor GetById(int id);
        // Add Actor to Database
        void add(Actor actor);
        // Update Actor to Database
        Actor Update(int id, Actor newActor);
        // Delete Actor from Database
        void Delete(int id);
    }
}
