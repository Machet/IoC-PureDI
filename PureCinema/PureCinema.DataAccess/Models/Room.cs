using System.Collections.Generic;

namespace PureCinema.DataAccess.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public int SeatsPerRow { get; set; }
        public int RowsOfSeats { get; set; }
        public virtual List<MovieRoomRelation> MovieRelations { get; set; }
    }
}
