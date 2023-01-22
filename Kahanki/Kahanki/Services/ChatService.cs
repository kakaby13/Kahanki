using Kahanki.Data;
using Kahanki.ViewModels;

namespace Kahanki.Services;

public class ChatService : IChatService
{
    private readonly IMatchService _matchService;
    private readonly ApplicationDbContext _db;

    public ChatService(IMatchService matchService, ApplicationDbContext db)
    {
        _matchService = matchService;
        _db = db;
    }

    public List<UserShortProfile> GetChatListByUserId(string userId)
    {
        var matches = _matchService.GetAllCouplesByUserId(userId);

        return matches
            .Select(match => _db.ApplicationUsers.Single(c => c.Id == match))
            .Select(user => new UserShortProfile
            {
                Id = user.Id, 
                Name = user.NormalizedUserName
            })
            .ToList();
    }

    public ChatModel GetChat(string userId, string targetUserId)
    {
        //TODO
        throw new NotImplementedException();
    }
}