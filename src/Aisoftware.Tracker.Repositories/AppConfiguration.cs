using Microsoft.Extensions.Configuration;
using System.IO;

namespace Aisoftware.Tracker.Repositories
{
    public class AppConfiguration : IAppConfiguration
    {
        private const string APP_SETTINGS = "appsettings.json";
        private readonly string _connectionString;
        private readonly string _baseUrl;
        private readonly string _version;
    
        public string ConnectionString { get => _connectionString; }
        public string BaseUrl { get => _baseUrl; }
        public string Version { get => _version; }

        public AppConfiguration()
        {
            var root = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(APP_SETTINGS, false)
                .Build();

            _baseUrl = root.GetSection("Urls").GetSection("BaseUrl").Value;
            _connectionString = root.GetSection("ConnectionStrings").GetSection("DataConnection").Value;
            _version = root.GetSection("Version").Value;
        }
    }
}