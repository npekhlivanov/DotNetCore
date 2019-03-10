using Microsoft.AspNetCore.Identity;

namespace Auth_SQLite.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string DisplayName { get; set; }
    }
}
