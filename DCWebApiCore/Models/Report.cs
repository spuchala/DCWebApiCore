using System;
using System.Collections.Generic;

namespace DCWebApiCore.Models
{
    public class Report
    {
        public List<Kid> Kids { get; set; }
        public string Day { get; set; }
        public string StartDay { get; set; }
        public string EndDay { get; set; }
        public string UserRole { get; set; }
        public Guid Id { get; set; }
    }
}