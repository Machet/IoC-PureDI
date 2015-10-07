using System;
using System.Collections.Generic;
using System.Linq;
using PureCinema.DataAccess.DTO;

namespace PureCinema.DataAccess.Repositories
{
    public class EfMovieRepository : IMovieRepository
    {
        public List<MovieDTO> GetMovies(DateTime start)
        {
            var context = new CinemaContext();
            return context.Movies.Select(m => new MovieDTO
            {
                Title = m.Title,
                Description = m.Description,
                ShowTimes = m.RoomRelations.Select(r => new SeanseDTO
                {
                    MovieRoomRelationId = r.MovieRoomRelationId,
                    StartTime = r.StartTime
                }).ToList()
            }).ToList();
        }
    }
}
