using PureCinema.Business;
using PureCinema.Business.AuditLogging;
using PureCinema.Business.Notifications;
using PureCinema.Controllers;
using PureCinema.DataAccess;
using PureCinema.DataAccess.Repositories;
using PureCinema.DataAccess.Sms;
using PureCinema.DataAccess.Smtp;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;

namespace PureCinema
{
    public class PureControllerFactory : DefaultControllerFactory
    {
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            Type controllerType = GetControllerType(requestContext, controllerName);
            if (controllerType == typeof(HomeController))
            {
                var context = new CinemaContext();
                var movieRepository = new EfMovieRepository(context);
                var roomRepository = new EfRoomRepository(context);
                var userRepository = new EfUserRepository(context);
                var templateRepository = new EfTemplateRepository();
                var notificationRepository = new EfNotificationRepository(context);

                var mailSender = new NetMailSender(notificationRepository);
                var smsSender = new MyMobileSmsSender(notificationRepository);

                var notifiers = new List<INotificationSender>
                {
                    new EmailNotificationSender(mailSender, templateRepository, userRepository),
                    new SmsNotificationSender(smsSender, templateRepository, userRepository),
                    new ApplicationNotificationSender(templateRepository, notificationRepository)
                };

                Func<int, AuditLogger> loggerFactory =
                    (userId) => new AuditLogger(userId, new EFAuditRepository(context));

                var movieService = new MovieService(movieRepository, roomRepository, notifiers, loggerFactory);

                return new HomeController(movieService);
            }

            return base.CreateController(requestContext, controllerName);
        }
    }
}