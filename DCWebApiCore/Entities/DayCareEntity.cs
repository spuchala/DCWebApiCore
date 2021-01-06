using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DCWebApiCore.Entities
{
    [Table("DayCare")]
    public class DayCareEntity
    {
        [Key]
        public Guid DayCareId { get; set; }
        public string DayCareName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string AdminName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string Source { get; set; }
        public string DayCareUniqueName { get; set; }
    }
}
