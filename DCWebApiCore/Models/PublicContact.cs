using System;

namespace DCWebApiCore.Models
{
    public class PublicContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string To { get; set; }
        public string Phone { get; set; }
        public string Comments { get; set; }
        public Guid DayCareId { get; set; }
    }
}
