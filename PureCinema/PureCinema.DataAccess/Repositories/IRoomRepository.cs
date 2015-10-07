using PureCinema.DataAccess.DTO;
using PureCinema.DataAccess.Models;

namespace PureCinema.DataAccess.Repositories
{
    public interface IRoomRepository
    {
        void Add(SeatAssignment seatAssignment);
        MovieRoomRelation GetRelation(int movieRoomRelationId);
        SeatAssignment GetSeatAssignment(int movieRoomRelationId, int row, int seatNumber);
        RoomDTO GetRoomByRelation(int movieRoomRelationId);
    }
}
