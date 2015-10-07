using System.Data.Entity;

namespace PureCinema.DataAccess.DbSetup
{
    public class CinemaDbInitializer : DropCreateDatabaseIfModelChanges<CinemaContext>
    {
        protected override void Seed(CinemaContext context)
        {
            MovieSeed.Seed(context);
            UsersSeed.Seed(context);
            RoomSeed.Seed(context);
            MovieTimeSeed.Seed(context);
        }
    }
}
