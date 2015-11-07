namespace PureCinema.Business.AuditLogging
{
	public interface IAuditRepository
	{
		void Add(AuditLog log);
	}
}
