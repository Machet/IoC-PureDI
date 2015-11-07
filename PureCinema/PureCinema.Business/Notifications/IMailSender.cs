namespace PureCinema.Business.Notifications
{
    public interface IMailSender
    {
        void Send(MailSettings content);
    }
}
