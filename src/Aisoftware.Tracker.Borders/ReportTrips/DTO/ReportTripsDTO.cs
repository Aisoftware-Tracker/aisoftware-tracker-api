using System;

namespace Aisoftware.Tracker.Borders.ReportTrips.DTO
{
    public class ReportTripsDTO
    {
        private int _deviceId;
        private string _deviceName;
        ///<summary>
        ///in knots
        ///</summary>
        private decimal _maxSpeed;
        ///<summary>
        ///in knots
        ///</summary>
        private decimal _averageSpeed;
        ///<summary>
        ///in meters
        ///</summary>
        private decimal _distance;
        ///<summary>
        ///in liters
        ///</summary>
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
        private string _driverName
    }
}