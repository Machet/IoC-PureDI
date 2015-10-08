using PureCinema.DataAccess.Models;
using PureCinema.DataAccess.Repositories;

namespace PureCinema.Business
{
    internal class ApplicationNotificationSender : INotificationSender
    {
        private ITemplateRepository _templateRepository;
        private INotificationRepository _notificationRepository;

        public ApplicationNotificationSender()
        {
            _templateRepository = new EfTemplateRepository();
            _notificationRepository = new EfNotificationRepository();
        }

        public void NotifyReservationReady(int userId, int row, int seatNumber)
        {
            string template = _templateRepository.GetHtmlTemplate();
            template = string.Format(template, row, seatNumber);
            _notificationRepository.Add(new Notification
            {
                Text = template
            });
        }
    }
}