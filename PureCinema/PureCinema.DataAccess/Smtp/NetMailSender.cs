using PureCinema.DataAccess.Models;
using PureCinema.DataAccess.Repositories;

namespace PureCinema.DataAccess.Smtp
{
    public class NetMailSender : IMailSender
    {
        public void Send(MailSettings content)
        {
            new EfNotificationRepository().Add(new Notification
            {
                Text = "Email send."
            });
        }
    }
}
