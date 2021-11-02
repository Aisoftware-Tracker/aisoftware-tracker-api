namespace Aisoftware.Tracker.Borders.ReportSummaries.Entities
{
    public class ReportSummary
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

        public int DeviceId { get => _deviceId; set => _deviceId = value; }
        public string DeviceName { get => _deviceName; set => _deviceName = value; }
        public decimal MaxSpeed { get => _maxSpeed; set => _maxSpeed = value; }
        public int AverageSpeed { get => _averageSpeed; set => _averageSpeed = value; }
        public decimal Distance { get => _distance; set => _distance = value; }
        public decimal SpentFuel { get => _spentFuel; set => _spentFuel = value; }
        public int EngineHours { get => _engineHours; set => _engineHours = value; }
    }
}

