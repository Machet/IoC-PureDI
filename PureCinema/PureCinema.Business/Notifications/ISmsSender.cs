namespace PureCinema.Business.Notifications
{
    public interface ISmsSender
    {
        void Send(SmsSettings settings);
    }
}
