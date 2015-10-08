namespace PureCinema.DataAccess.Smtp
{
    public interface IMailSender
    {
        void Send(MailSettings content);
    }
}
