using System;

namespace Aisoftware.Tracker.Borders.ReportTrips.Entities
{
    public class ReportTrip
    {
        private int _deviceId;
        private string _deviceName;
        private decimal _maxSpeed;
        private decimal _averageSpeed;
        private decimal _distance;
        private decimal _spentFuel;
        private int _duration;
        private DateTime _startTime;
        private string _startAddress;
        private decimal _startLat;
        private decimal _startLon;
        private DateTime _endTime;
        private string _endAddress;
        private decimal _endLat;
        private decimal _endLon;
        private string _driverUniqueId;
        private string _driverName;

        public int DeviceId { get => _deviceId; set => _deviceId = value; }
        public string DeviceName { get => _deviceName; set => _deviceName = value; }

        ///<summary>
        ///in knots
        ///</summary>
        public decimal MaxSpeed { get => _maxSpeed; set => _maxSpeed = value; }

        ///<summary>
        ///in knots
        ///</summary>
        public decimal AverageSpeed { get => _averageSpeed; set => _averageSpeed = value; }

        ///<summary>
        ///in meters
        ///</summary>
        public decimal Distance { get => _distance; set => _distance = value; }

        ///<summary>
        ///in liters
        ///</summary>
        public decimal SpentFuel { get => _spentFuel; set => _spentFuel = value; }
        public int Duration { get => _duration; set => _duration = value; }
        public DateTime StartTime { get => _startTime; set => _startTime = value; }
        public string StartAddress { get => _startAddress; set => _startAddress = value; }
        public decimal StartLat { get => _startLat; set => _startLat = value; }
        public decimal StartLon { get => _startLon; set => _startLon = value; }
        public DateTime EndTime { get => _endTime; set => _endTime = value; }
        public string EndAddress { get => _endAddress; set => _endAddress = value; }
        public decimal EndLat { get => _endLat; set => _endLat = value; }
        public decimal EndLon { get => _endLon; set => _endLon = value; }
        public string DriverUniqueId { get => _driverUniqueId; set => _driverUniqueId = value; }
        public string DriverName { get => _driverName; set => _driverName = value; }
    }
}