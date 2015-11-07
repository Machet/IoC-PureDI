﻿using PureCinema.Business.DTO;

namespace PureCinema.Business
{
    public interface IRoomRepository
    {
        void Add(SeatAssignment seatAssignment);
        MovieRoomRelation GetRelation(int movieRoomRelationId);
        SeatAssignment GetSeatAssignment(int movieRoomRelationId, int row, int seatNumber);
        RoomDTO GetRoomByRelation(int movieRoomRelationId);
    }
}