using PureCinema.DataAccess.Models;
using PureCinema.DataAccess.Repositories;

namespace PureCinema.DataAccess.Sms
{
    public class MyMobileSmsSender : ISmsSender
    {
        public void Send(SmsSettings settings)
        {
            new EfNotificationRepository().Add(new Notification
            {
                Text = "Sms send."
            });
        }
    }
}
