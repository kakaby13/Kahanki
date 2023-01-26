namespace Kahanki.Models
{
    public class UserSettings : BaseEntity
    {
        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public int Age { get; set; }

        public int Sex { get; set; }

        public int Preferences { get; set; }

        public string RealName { get; set; }

        public string ShortBio { get; set; }
    }
}
