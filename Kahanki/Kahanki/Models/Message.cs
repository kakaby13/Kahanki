namespace Kahanki.Models
{
    public class Message : BaseEntity
    {
        public string SenderId { get; set; }
        public ApplicationUser Sender { get; set; }

        public string RecieverId { get; set; }
        public ApplicationUser Reciever { get; set; }

        public string Content { get; set; }

        public DateTime Created { get; set; }
    }
}
