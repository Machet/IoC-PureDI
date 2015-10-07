using System.Data.Entity;

using PureCinema.DataAccess.Models;

namespace PureCinema.DataAccess
{
	public class CinemaContext : DbContext
	{
		public DbSet<Movie> Movies { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MovieRoomRelation> RoomRelations { get; set; }
        public DbSet<SeatAssignment> SeatAssignments { get; set; }
    }
}
