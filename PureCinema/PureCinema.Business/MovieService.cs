using System;
using System.Collections.Generic;
using PureCinema.Business.AuditLogging;
using PureCinema.DataAccess.DTO;
using PureCinema.DataAccess.Models;
using PureCinema.DataAccess.Repositories;

namespace PureCinema.Business
{
	public class MovieService
	{
		public List<MovieDTO> GetMovies(DateTime start)
		{
			IMovieRepository repository = new EfMovieRepository();
			return repository.GetMovies(start);
		}

		public RoomDTO GetRoomByRelation(int movieRoomRelationId)
		{
			IRoomRepository repository = new EfRoomRepository();
			return repository.GetRoomByRelation(movieRoomRelationId);
		}

		public bool ReserveSeat(int userId, int movieRoomRelationId, int row, int seatNumber)
		{
			IRoomRepository repository = new EfRoomRepository();
			List<INotificationSender> notifiers = new List<INotificationSender>
            {
                new EmailNotificationSender(),
                new SmsNotificationSender(),
                new ApplicationNotificationSender()
            };

			MovieRoomRelation relation = repository.GetRelation(movieRoomRelationId);

			if (relation == null)
			{
				return false;
			}

			if (relation.StartTime < DateTime.Now.TimeOfDay)
			{
				return false;
			}

			if (relation.Room.SeatsPerRow < row || row <= 0)
			{
				return false;
			}

			if (relation.Room.SeatsPerRow < seatNumber || seatNumber <= 0)
			{
				return false;
			}

			if (repository.GetSeatAssignment(movieRoomRelationId, row, seatNumber) != null)
			{
				return false;
			}

			repository.Add(new SeatAssignment
			{
				MovieRoomRelationId = movieRoomRelationId,
				Row = row,
				SeatNumber = seatNumber,
				UserId = userId
			});

			foreach (var notifier in notifiers)
			{
				try
				{
					notifier.NotifyReservationReady(userId, row, seatNumber);
				}
				catch (Exception e)
				{
					// log 
				}
			}

			new AuditLogger(userId).LogChanges(string.Format("Booked seat {0} in row {1}", seatNumber, row));

			return true;
		}
	}
}
