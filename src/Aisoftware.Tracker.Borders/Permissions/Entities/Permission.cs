namespace Aisoftware.Tracker.Borders.Permissions.Entities
{
    public class Permission
    {
      private int _userId;
        private int _deviceId;
        private int _groupId;
        private int _geofenceId;
        private int _calendarId;
        private int _attributeId;
        private int _driverId;
        private int _managedUserId;

        ///<summary>
        ///User Id, can be only first parameter
        ///</summary>
        public int UserId { get => _userId; set => _userId = value; }

        ///<summary>
        ///Device Id, can be first parameter or second only in combination with userId
        ///</summary>
        public int DeviceId { get => _deviceId; set => _deviceId = value; }

        ///<summary>
        ///Group Id, can be first parameter or second only in combination with userId
        ///</summary>
        public int GroupId { get => _groupId; set => _groupId = value; }

        ///<summary>
        ///Geofence Id, can be second parameter only
        ///</summary>
        public int GeofenceId { get => _geofenceId; set => _geofenceId = value; }

        ///<summary>
        ///Calendar Id, can be second parameter only and only in combination with userId
        ///</summary>
        public int CalendarId { get => _calendarId; set => _calendarId = value; }

        ///<summary>
        ///Computed Attribute Id, can be second parameter only
        ///</summary>
        public int AttributeId { get => _attributeId; set => _attributeId = value; }

        ///<summary>
        ///Driver Id, can be second parameter only
        ///</summary>
        public int DriverId { get => _driverId; set => _driverId = value; }

        ///<summary>
        ///User Id, can be second parameter only and only in combination with userId
        ///</summary>
        public int ManagedUserId { get => _managedUserId; set => _managedUserId = value; }
    }
}