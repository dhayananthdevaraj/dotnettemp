using System;
namespace dotnetapp.Models
{
    public class User
    {
        public int UserId { get; set; } 
        public string UserName { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string UserRole { get; set; }
        public string Password { get; set; }
    }
}
