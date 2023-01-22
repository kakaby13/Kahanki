using Kahanki.ViewModels;

namespace Kahanki.Services
{
    public interface IChatService
    {
        List<UserShortProfile> GetChatListByUserId(string userId);

        ChatModel GetChat(string userId, string targetUserId);
    }
}
