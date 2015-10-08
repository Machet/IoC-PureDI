using PureCinema.DataAccess.Models;
using PureCinema.DataAccess.Repositories;
using PureCinema.DataAccess.Smtp;
using System;

namespace PureCinema.Business
{
    internal class EmailNotificationSender : INotificationSender
    {
        private IMailSender _sender;
        private ITemplateRepository _templateRepository;
        private IUserRepository _userRepository;

        public EmailNotificationSender()
        {
            _sender = new NetMailSender();
            _templateRepository = new EfTemplateRepository();
            _userRepository = new EfUserRepository();
        }

        public void NotifyReservationReady(int userId, int row, int seatNumber)
        {
            string template = _templateRepository.GetHtmlTemplate();
            template = string.Format(template, row, seatNumber);
            User user = _userRepository.GetUser(userId);
            _sender.Send(new MailSettings
            {
                EmailTo = user.Email,
                EmailFrom = "noReply@cinema.com",
                Subject = "Result",
                Content = template
            });
        }
    }
}