using System;
using System.Collections.Generic;

namespace PureCinema.Business.DTO
{
    public interface IMovieRepository
    {
        List<MovieDTO> GetMovies(DateTime start);
    }
}
