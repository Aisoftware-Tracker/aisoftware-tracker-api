using System;

namespace Aisoftware.Tracker.Borders.Notifications.DTO
{
    public class NotificationParam
    {
        private bool? all;
        private int? userId;
        private int? deviceId; 
        private int? groupId;
        private bool refresh;

        public bool? All { get => all; set => all = value; }
        public int? UserId { get => userId; set => userId = value; }
        public int? DeviceId { get => deviceId; set => deviceId = value; }
        public int? GroupId { get => groupId; set => groupId = value; }
        public bool Refresh { get => refresh; set => refresh = value; }
    }
}
