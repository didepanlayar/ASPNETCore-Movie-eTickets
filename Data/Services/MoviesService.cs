using Microsoft.EntityFrameworkCore;
using Movie_eTickets.Data.Base;
using Movie_eTickets.Data.ViewModels;
using Movie_eTickets.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_eTickets.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        private readonly AppDbContext _context;
        public MoviesService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewMovieAsync(NewMovieVM data)
        {
            var newMovie = new Movie()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageURL = data.ImageURL,
                CinemaId = data.CinemaId,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                MovieCategory = data.MovieCategory,
                ProducerId = data.ProducerId
            };
            await _context.Movies.AddAsync(newMovie);
            await _context.SaveChangesAsync();
            // Add Movie Actors
            foreach (var actorId in data.ActorIds)
            {
                var newActorMovie = new Actor_Movie()
                {
                    MovieId = newMovie.Id,
                    ActorId = actorId
                };
                await _context.Actor_Movies.AddAsync(newActorMovie);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = await _context.Movies
                .Include(c => c.Cinema)
                .Include(p => p.Producer)
                .Include(am => am.Actors_Movies).ThenInclude(a => a.Actor)
                .FirstOrDefaultAsync(n => n.Id == id);
            return movieDetails;
        }

        public async Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues()
        {
            var response = new NewMovieDropdownsVM()
            {
                Producers = await _context.Producers.OrderBy(n => n.FullName).ToListAsync(),
                Cinemas = await _context.Cinemas.OrderBy(n => n.Name).ToListAsync(),
                Actors = await _context.Actors.OrderBy(n => n.FullName).ToListAsync()
            };
            return response;
        }

        public async Task UpdateMovieAsync(NewMovieVM data)
        {
            var dataMovie = await _context.Movies.FirstOrDefaultAsync(n => n.Id == data.Id);
            if(dataMovie != null)
            {
                dataMovie.Name = data.Name;
                dataMovie.Description = data.Description;
                dataMovie.Price = data.Price;
                dataMovie.ImageURL = data.ImageURL;
                dataMovie.CinemaId = data.CinemaId;
                dataMovie.StartDate = data.StartDate;
                dataMovie.EndDate = data.EndDate;
                dataMovie.MovieCategory = data.MovieCategory;
                dataMovie.ProducerId = data.ProducerId;
                await _context.SaveChangesAsync();
            };
            // Remove Existing Movie Actors
            var existingDataActors = _context.Actor_Movies.Where(n => n.MovieId == data.Id).ToList();
            _context.Actor_Movies.RemoveRange(existingDataActors);
            await _context.SaveChangesAsync();
            // Add Movie Actors
            foreach (var actorId in data.ActorIds)
            {
                var newActorMovie = new Actor_Movie()
                {
                    MovieId = data.Id,
                    ActorId = actorId
                };
                await _context.Actor_Movies.AddAsync(newActorMovie);
            }
            await _context.SaveChangesAsync();
        }
    }
}
