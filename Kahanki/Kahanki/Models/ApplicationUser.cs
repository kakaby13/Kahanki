using Microsoft.AspNetCore.Identity;

namespace Kahanki.Models
{
    public class ApplicationUser : IdentityUser, IEntity
    {
        public virtual UserSettings UserSettings { get; set; } = new UserSettings();
    }
}