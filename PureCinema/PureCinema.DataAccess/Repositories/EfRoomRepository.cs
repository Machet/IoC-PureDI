﻿using System.Linq;
using PureCinema.DataAccess.Models;
using PureCinema.DataAccess.DTO;

namespace PureCinema.DataAccess.Repositories
{
    public class EfRoomRepository : IRoomRepository
    {
        private CinemaContext _context;

        public EfRoomRepository()
        {
            _context = new CinemaContext();
        }

        public void Add(SeatAssignment seatAssignment)
        {
            _context.SeatAssignments.Add(seatAssignment);
            _context.SaveChanges();
        }

        public MovieRoomRelation GetRelation(int movieRoomRelationId)
        {
            return _context.RoomRelations
                .FirstOrDefault(r => r.MovieRoomRelationId == movieRoomRelationId);
        }

        public SeatAssignment GetSeatAssignment(int movieRoomRelationId, int row, int seatNumber)
        {
            return _context.SeatAssignments
                .FirstOrDefault(a => a.MovieRoomRelationId == movieRoomRelationId && a.Row == row && a.SeatNumber == seatNumber);
        }

        public RoomDTO GetRoomByRelation(int movieRoomRelationId)
        {
            return _context.RoomRelations
                .Where(r => r.MovieRoomRelationId == movieRoomRelationId)
                .Select(r => new RoomDTO
                {
                    RowsOfSeats = r.Room.RowsOfSeats,
                    SeatsPerRow = r.Room.SeatsPerRow,
                    TakenSeats = r.SeatAssignments.Select(sa => new SeatDTO
                    {
                        SeatNumber = sa.SeatNumber,
                        SeatRow = sa.Row
                    }).ToList()
                }).FirstOrDefault();
        }
    }
}
