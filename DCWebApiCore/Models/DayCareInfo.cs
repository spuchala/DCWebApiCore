using System;
using System.Collections.Generic;

namespace DCWebApiCore.Models
{
    public class DayCareInfo
    {
        public DayCareInfo()
        {
            Snaps = new List<DayCareSnap>();
        }
        public Guid DayCareId { get; set; }
        public string DescriptionHome { get; set; }
        public string DescriptionAboutUs { get; set; }
        public string DescriptionProgram { get; set; }
        public string LogoUrl { get; set; }
        public List<DayCareSnap> Snaps { get; set; }
    }

    public class DayCareSnap
    {
        public int SnapId { get; set; }        
        public string  SnapUrl { get; set; }
        public string Error { get; set; }
    }
}
