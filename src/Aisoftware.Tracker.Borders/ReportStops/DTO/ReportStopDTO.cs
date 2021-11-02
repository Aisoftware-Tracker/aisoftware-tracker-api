using System;

namespace Aisoftware.Tracker.Borders.ReportStops.DTO
{
    public class ReportStopDTO
    {
        private int _deviceId;
        private string _deviceName;
        private int _duration;
        private DateTime _startTime;
        private string _address;
        private decimal _lat;
        private decimal _lon;
        private string _endTime;
        ///<summary>
        ///in liters
        ///</summary>
        private decimal _spentFuel;
        private string _engineHours;       
    }
}