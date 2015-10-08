using PureCinema.DataAccess.Models;

namespace PureCinema.DataAccess.Repositories
{
    public class EfUserRepository : IUserRepository
    {
        public User GetUser(int userId)
        {
            using (var context = new CinemaContext())
            {
                return context.Users.Find(userId);
            }
        }
    }
}
