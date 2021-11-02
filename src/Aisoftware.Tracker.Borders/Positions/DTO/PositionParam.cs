using System;

namespace Aisoftware.Tracker.Borders.Positions.DTO
{
    public class PositionParam
    {
        ///<summary>
        /// To fetch one or more positions. Multiple params can be passed like id=31 and id=42
        ///</summary>
        private int[] _id;
        private int? _deviceId;
        private DateTime? _from;
        private DateTime? _to;

        public int[] Id { get => _id; set => _id = value; }
        public int? DeviceId { get => _deviceId; set => _deviceId = value; }
        public DateTime? From { get => _from; set => _from = value; }
        public DateTime? To { get => _to; set => _to = value; }

    }
}
