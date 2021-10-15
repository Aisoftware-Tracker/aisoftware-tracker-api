using Microsoft.Extensions.Options;

namespace Aisoftware.Tracker.Api
{
    public class Config : IOptions<Config>
    {
        public string UserIP { get; set; }

        public Config Value { get { return this; } }
    }
}
