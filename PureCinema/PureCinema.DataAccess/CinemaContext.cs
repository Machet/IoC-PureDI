using System.Data.Entity;

using PureCinema.DataAccess.Models;

namespace PureCinema.DataAccess
{
	public class CinemaContext : DbContext
	{
		public DbSet<Movie> Movies { get; set; }
	}
}
