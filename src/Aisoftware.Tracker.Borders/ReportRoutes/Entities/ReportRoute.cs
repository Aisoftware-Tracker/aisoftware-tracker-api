using System;

namespace Aisoftware.Tracker.Borders.ReportRoutes.Entities
{
    public class ReportRoute
    {
        private int _id;
        private int _deviceId;
        private string _protocol;
        private DateTime _deviceTime;
        private DateTime _fixTime;
        private DateTime _serverTime;
        private bool _outdated;
        private bool _valid;
        private int _latitude;
        private int _longitude;
        private int _altitude;
        private int _speed;
        private int _course;
        private string _address;
        private int _accuracy;
        private object _network;
        private object _attributes;

        public int Id { get => _id; set => _id = value; }
        public int DeviceId { get => _deviceId; set => _deviceId = value; }
        public string Protocol { get => _protocol; set => _protocol = value; }
        public DateTime DeviceTime { get => _deviceTime; set => _deviceTime = value; }
        public DateTime FixTime { get => _fixTime; set => _fixTime = value; }
        public DateTime ServerTime { get => _serverTime; set => _serverTime = value; }
        public bool Outdated { get => _outdated; set => _outdated = value; }
        public bool Valid { get => _valid; set => _valid = value; }
        public int Latitude { get => _latitude; set => _latitude = value; }
        public int Longitude { get => _longitude; set => _longitude = value; }
        public int Altitude { get => _altitude; set => _altitude = value; }
        public int Speed { get => _speed; set => _speed = value; }
        public int Course { get => _course; set => _course = value; }
        public string Address { get => _address; set => _address = value; }
        public int Accuracy { get => _accuracy; set => _accuracy = value; }
        public object Network { get => _network; set => _network = value; }
        public object Attributes { get => _attributes; set => _attributes = value; }
    }
}