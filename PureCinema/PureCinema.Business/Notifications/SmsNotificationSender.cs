using PureCinema.DataAccess.Models;
using PureCinema.DataAccess.Repositories;
using PureCinema.DataAccess.Sms;

namespace PureCinema.Business
{
    internal class SmsNotificationSender : INotificationSender
    {
        private ISmsSender _sender;
        private ITemplateRepository _templateRepository;
        private IUserRepository _userRepository;

        public SmsNotificationSender()
        {
            _sender = new MyMobileSmsSender();
            _templateRepository = new EfTemplateRepository();
            _userRepository = new EfUserRepository();
        }

        public void NotifyReservationReady(int userId, int row, int seatNumber)
        {
            string template = _templateRepository.GetPlainTextTemplate();
            template = string.Format(template, row, seatNumber);
            User user = _userRepository.GetUser(userId);
            _sender.Send(new SmsSettings
            {
                Number = user.MobilePhone,
                Message = template
            });
        }
    }
}