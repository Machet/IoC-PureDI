namespace PureCinema.Business.Notifications
{
    public interface INotificationSender
    {
        void NotifyReservationReady(int userId, int row, int seatNumber);
    }
}