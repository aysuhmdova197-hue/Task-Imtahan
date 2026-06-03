using Microsoft.AspNetCore.Identity;

namespace Folder14.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
    }
}
