using PureCinema.DataAccess.Models;

namespace PureCinema.DataAccess.Repositories
{
	public interface IAuditRepository
	{
		void Add(AuditLog log);
	}
}
