using System;
using System.Collections.Generic;
using PureCinema.DataAccess.DTO;

namespace PureCinema.DataAccess.Repositories
{
    public interface IMovieRepository
    {
        List<MovieDTO> GetMovies(DateTime start);
    }
}
