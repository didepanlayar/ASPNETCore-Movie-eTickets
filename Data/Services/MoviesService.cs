using Movie_eTickets.Data.Base;
using Movie_eTickets.Models;

namespace Movie_eTickets.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        public MoviesService(AppDbContext context) : base(context) {}
    }
}
