namespace PureCinema.Business.Notifications
{
    public interface ITemplateRepository
    {
        string GetPlainTextTemplate();
        string GetHtmlTemplate();
    }
}
