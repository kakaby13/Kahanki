namespace Kahanki.Models
{
    public class UserSettings : BaseEntity
    {
        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public int Age { get; set; }
    }
}
