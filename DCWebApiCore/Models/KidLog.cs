using System;
using System.Collections.Generic;

namespace DCWebApiCore.Models
{
    public class KidLog
    {
        public Guid LogId { get; set; }
        public int KidId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public List<Food> Foods { get; set; }
        public List<Potty> Pottys { get; set; }
        public List<Nap> Naps { get; set; }
        public List<Activity> Activities { get; set; }
        public string ProblemsConcerns { get; set; }
        public string SuppliesNeeded { get; set; }
        public string Comments { get; set; }
        public string Error { get; set; }
    }
}