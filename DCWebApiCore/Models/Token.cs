using System;

namespace DCWebApiCore.Models
{
    public class Token
    {
        public string AccessToken { get; set; }
        public Guid Id { get; set; }
        public DateTime DateIssued { get; set; }
        public string Role { get; set; }
    }
}
