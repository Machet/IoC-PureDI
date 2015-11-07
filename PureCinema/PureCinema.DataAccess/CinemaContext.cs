using System.Data.Entity;

using PureCinema.Business.AuditLogging;
using PureCinema.Business;
using PureCinema.Business.Notifications;

namespace PureCinema.DataAccess
{
    public class CinemaContext : DbContext
    {
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MovieRoomRelation> RoomRelations { get; set; }
        public DbSet<SeatAssignment> SeatAssignments { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}
