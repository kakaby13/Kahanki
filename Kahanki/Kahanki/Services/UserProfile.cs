using Kahanki.Data;

namespace Kahanki.Services;

public class UserProfile : IUserProfile
{
    private readonly ApplicationDbContext _db;

    public UserProfile(ApplicationDbContext db)
    {
        _db = db;
    }

    public UserProfile GetUserProfileByUserId(string userId)
    {

        throw new NotImplementedException();
    }
}