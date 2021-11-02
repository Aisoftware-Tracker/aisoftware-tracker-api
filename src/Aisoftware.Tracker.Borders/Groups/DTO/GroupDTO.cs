using System;

namespace Aisoftware.Tracker.Borders.Groups.DTO
{
    public class GroupDTO
    {
        private int _id;
        private string _name;
        private int _groupId;
        private object _attributes;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int GroupId { get => _groupId; set => _groupId = value; }
        public object Attributes { get => _attributes; set => _attributes = value; }
    }
}