using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DCWebApiCore.Entities
{
    [Table("Kid")]
    public class KidEntity
    {
        [Key]
        public int KidId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public string GaurdianName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Allergies { get; set; }
        public Guid DayCareId { get; set; }
        public Guid ClassId { get; set; }
        public bool Active { get; set; }
        public string InActiveReason { get; set; }
        public string Avatar { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
