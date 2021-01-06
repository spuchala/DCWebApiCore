using System;

namespace DCWebApiCore.Models
{
    public class Kid : User
    {
        public string Allergies { get; set; }
        public int KidId { get; set; }
        public Guid DayCareId { get; set; }
        public string DOB { get; set; }
        public string DayCareName { get; set; }
        public string ClassName { get; set; }
        public Guid ClassId { get; set; }
        public KidLog Log { get; set; }
        public string GuardianName { get; set; }
        public bool HasReportToday { get; set; }
        public string Avatar { get; set; }
    }
}