using System;
using System.Collections.Generic;

using PureCinema.DataAccess.Models;

namespace PureCinema.DataAccess.Repositories
{
	public interface IMovieRepository
	{
		List<Movie> GetMovies(DateTime start);
	}
}
