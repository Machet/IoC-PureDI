namespace PureCinema.Business
{
    public interface INotificationSender
    {
        void NotifyReservationReady(int userId, int row, int seatNumber);
    }
}