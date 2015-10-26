using PureCinema.DataAccess.Models;

namespace PureCinema.DataAccess.Repositories
{
	public class EFAuditRepository : IAuditRepository
	{
		public void Add(AuditLog auditLog)
		{
			using (var context = new CinemaContext())
			{
				context.AuditLogs.Add(auditLog);
				context.SaveChanges();
			}
		}
	}
}
