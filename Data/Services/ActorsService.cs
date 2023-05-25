using Movie_eTickets.Data.Base;
using Movie_eTickets.Models;

namespace Movie_eTickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
       public ActorsService(AppDbContext context) : base(context) {}
    }
}
