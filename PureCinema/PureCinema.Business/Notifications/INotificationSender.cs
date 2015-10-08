namespace PureCinema.Business
{
    internal interface INotificationSender
    {
        void NotifyReservationReady(int userId, int row, int seatNumber);
    }
}