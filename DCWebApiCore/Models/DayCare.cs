using System;
using System.Collections.Generic;

namespace DCWebApiCore.Models
{
    public class DayCare : User
    {
        public Guid DayCareId { get; set; }
        public string DayCareName { get; set; }
        public List<Kid> Kids { get; set; }
        public Settings Settings { get; set; }
        public string Source { get; set; }
    }
}