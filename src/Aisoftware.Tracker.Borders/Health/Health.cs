using System;

namespace Aisoftware.Tracker.Borders.Health
{
    public class Health
    {
        private string _status;
        private string _info;
        private DateTime _now;
        private string _version;

        public string Status { get => _status; set => _status = value; }
        public string Info { get => _info; set => _info = value; }
        public DateTime Now { get => _now; set => _now = value; }
        public string Version { get => _version; set => _version = value; }
    }
}
