using System;

namespace Aisoftware.Tracker.Borders.Events.Entities
{
    public class Event
    {
        private int _id;
        private string _type;
        private DateTime _serverTime;
        private int _deviceId;
        private int _positionId;
        private int _geofenceId;
        private int _maintenanceId;
        private object _attributes;

        public int Id { get => _id; set => _id = value; }
        public string Type { get => _type; set => _type = value; }
        public DateTime ServerTime { get => _serverTime; set => _serverTime = value; }
        public int DeviceId { get => _deviceId; set => _deviceId = value; }
        public int PositionId { get => _positionId; set => _positionId = value; }
        public int GeofenceId { get => _geofenceId; set => _geofenceId = value; }
        public int MaintenanceId { get => _maintenanceId; set => _maintenanceId = value; }
        public object Attributes { get => _attributes; set => _attributes = value; }
    }
}