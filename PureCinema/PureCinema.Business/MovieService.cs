using System;
using System.Collections.Generic;

using PureCinema.DataAccess.Models;
using PureCinema.DataAccess.Repositories;

namespace PureCinema.Business
{
	public class MovieService
	{
		public List<Movie> GetMovies(DateTime start)
		{
			IMovieRepository repository = new EfMovieRepository();
			return repository.GetMovies(start);
		}
	}
}
