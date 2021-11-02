namespace Aisoftware.Tracker.Repositories
{
    public interface IAppConfiguration
    {
        string ConnectionString { get; } 
        string BaseUrl { get; } 
        string CookieName { get; } 
    }
}