using PureCinema.Business.Notifications;

namespace PureCinema.DataAccess.Sms
{
    public class MyMobileSmsSender : ISmsSender
    {
        private INotificationRepository _notificationRepository;

        public MyMobileSmsSender(INotificationRepository notificicationRepository)
        {
            _notificationRepository = notificicationRepository;
        }

        public void Send(SmsSettings settings)
        {
            _notificationRepository.Add(new Notification
            {
                Text = "Sms send."
            });
        }
    }
}
