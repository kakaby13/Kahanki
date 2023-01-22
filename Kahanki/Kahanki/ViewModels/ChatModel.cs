using Kahanki.Models;

namespace Kahanki.ViewModels
{
    public class ChatModel
    {
        public UserShortProfile TargetUserProfile { get; set; }

        public List<Message> Messages { get; set; }
    }
}
