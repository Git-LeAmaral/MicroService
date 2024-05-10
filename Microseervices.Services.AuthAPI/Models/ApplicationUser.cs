using Microsoft.AspNetCore.Identity;

namespace Microseervices.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
