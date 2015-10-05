using System;
using System.Collections.Generic;
using System.Linq;
using PureCinema.DataAccess.Models;

namespace PureCinema.DataAccess.Repositories
{
	public class EfMovieRepository : IMovieRepository
	{
		public List<Movie> GetMovies(DateTime start)
		{
			var context = new CinemaContext();
			return context.Movies.Select(m => m).ToList();
		}
	}
}
