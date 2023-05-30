﻿using Movie_eTickets.Data.Base;
using Movie_eTickets.Models;
using System.Threading.Tasks;

namespace Movie_eTickets.Data.Services
{
    public interface IMoviesService: IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
    }
}
