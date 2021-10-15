using Aisoftware.Tracker.Borders.Users.DTO;
using Microsoft.Extensions.Options;
using System;

namespace Aisoftware.Tracker.Api.Handlers
{
    public class HandlerFactory : IDisposable
    {
        private IOptions<Config> _config;
        private string _userIP;
        private UserDTO user;

        public string UserIP
        {
            get => _userIP;
            set
            {
                if (_config != null)
                {
                    _config.Value.UserIP = value;
                }

                _userIP = value;
            }
        }

        public UserDTO User { get => user; set => user = value; }

        public void Dispose() { }
    }
}