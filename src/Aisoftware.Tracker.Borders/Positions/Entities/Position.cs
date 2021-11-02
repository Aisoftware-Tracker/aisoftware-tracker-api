using System;

namespace Aisoftware.Tracker.Borders.Positions.Entities
{
    public class Position
    {
        private int _id;
        private int _deviceId;
        private string _protocol;
        private DateTime _deviceTime;
        private DateTime _fixTime;
        private DateTime _serverTime;
        private bool _outdated;
        private bool _valid;
        private decimal _latitude;
        private decimal _longitude;
        private decimal _altitude;
        private decimal _speed;
        private decimal _course;
        private string _address;
        private decimal _accuracy;
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
        public decimal Latitude { get => _latitude; set => _latitude = value; }
        public decimal Longitude { get => _longitude; set => _longitude = value; }
        public decimal Altitude { get => _altitude; set => _altitude = value; }
        public decimal Speed { get => _speed; set => _speed = value; }
        public decimal Course { get => _course; set => _course = value; }
        public string Address { get => _address; set => _address = value; }
        public decimal Accuracy { get => _accuracy; set => _accuracy = value; }
        public object Network { get => _network; set => _network = value; }
        public object Attributes { get => _attributes; set => _attributes = value; }
    }
}
