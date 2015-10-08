namespace PureCinema.DataAccess.Repositories
{
    public interface ITemplateRepository
    {
        string GetPlainTextTemplate();
        string GetHtmlTemplate();
    }
}
