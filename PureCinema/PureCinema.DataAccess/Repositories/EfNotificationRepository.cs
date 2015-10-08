using PureCinema.DataAccess.Models;

namespace PureCinema.DataAccess.Repositories
{
    public class EfNotificationRepository : INotificationRepository
    {
        public void Add(Notification notification)
        {
            using (var context = new CinemaContext())
            {
                context.Notifications.Add(notification);
                context.SaveChanges();
            }
        }
    }
}
