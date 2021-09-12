using System;

namespace Aisoftware.Tracker.Borders.ReportSumaries.Entities
{
    public class ReportSumary
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
        private int _averageSpeed;
        ///<summary>
        ///in meters
        ///</summary>
        private decimal _distance;
        ///<summary>
        ///in liters
        ///</summary>
        private decimal _spentFuel;
        private int _engineHours;
    }
}