using System;
using System.ComponentModel.DataAnnotations;

namespace DCWebApiCore.Models
{
    public class User
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public string Error { get; set; }
        public string Role { get; set; }
        public Guid Id { get; set; }
    }
}