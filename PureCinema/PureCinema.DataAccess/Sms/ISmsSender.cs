namespace PureCinema.DataAccess.Sms
{
    public interface ISmsSender
    {
        void Send(SmsSettings settings);
    }
}
