namespace Aisoftware.Tracker.Borders.Notifications.Entities
{
    public class Notification
    {
        private int id;
        private string type;
        private bool always;
        private bool web;
        private bool mail;
        private bool sms;
        private int calendarId;
        private object attributes;

        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public bool Always { get => always; set => always = value; }
        public bool Web { get => web; set => web = value; }
        public bool Mail { get => mail; set => mail = value; }
        public bool Sms { get => sms; set => sms = value; }
        public int CalendarId { get => calendarId; set => calendarId = value; }
        public object Attributes { get => attributes; set => attributes = value; }
    }
}