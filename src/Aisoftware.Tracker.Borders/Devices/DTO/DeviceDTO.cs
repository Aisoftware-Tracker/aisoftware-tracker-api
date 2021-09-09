using System;
using System.Collections.Generic;

namespace Aisoftware.Tracker.Borders.Devices.DTO
{
    public class Device
    {
        private int _id;
        private string _name;
        private string _uniqueId;
        private string _status;
        private bool _disabled;
        private DateTime _lastUpdate;
        private int _positionId;
        private int _groupId;
        private string _phone;
        private string _model;
        private string _contact;
        private string _category;
        private List<int> _geofenceIds;
        private object _attributes;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string UniqueId { get => _uniqueId; set => _uniqueId = value; }
        public string Status { get => _status; set => _status = value; }
        public bool Disabled { get => _disabled; set => _disabled = value; }
        public DateTime LastUpdate { get => _lastUpdate; set => _lastUpdate = value; }
        public int PositionId { get => _positionId; set => _positionId = value; }
        public int GroupId { get => _groupId; set => _groupId = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Model { get => _model; set => _model = value; }
        public string Contact { get => _contact; set => _contact = value; }
        public string Category { get => _category; set => _category = value; }
        public List<int> GeofenceIds { get => _geofenceIds; set => _geofenceIds = value; }
        public object Attributes { get => _attributes; set => _attributes = value; }
    }
}