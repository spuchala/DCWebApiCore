using System;

namespace DCWebApiCore.Models
{
    public class Attendance
    {
        public int KidId { get; set; }
        public string KidName { get; set; }
        public Guid DayCareId { get; set; }
        public bool HasAttended { get; set; }
        public string Avatar { get; set; }
        public string Sex { get; set; }
    }
}