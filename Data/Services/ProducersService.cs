using Movie_eTickets.Data.Base;
using Movie_eTickets.Models;

namespace Movie_eTickets.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context) {}
    }
}
