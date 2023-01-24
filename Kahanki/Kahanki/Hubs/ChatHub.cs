using Microsoft.AspNetCore.SignalR;

namespace Kahanki.Hubs
{
    public class ChatHub : Hub  
    {
        public async Task SendMessage(string chatId, string user, string message)
        {
            await Clients.All.SendAsync(chatId, user, message);
        }
    }
}
