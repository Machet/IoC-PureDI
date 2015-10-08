using System;
using PureCinema.DataAccess.Models;

namespace PureCinema.DataAccess.Repositories
{
    public interface INotificationRepository
    {
        void Add(Notification notification);
    }
}
