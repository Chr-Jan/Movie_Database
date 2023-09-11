using Microsoft.AspNetCore.Identity;

namespace MvcMovie.Models
{
    public class ApplicationUser : IdentityUser
    {
        // You can add custom properties here if needed.
        // For example, if you want to store additional user information:
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

