using Kahanki.ViewModels;

namespace Kahanki.Services;

public interface IUserProfile
{
    UserProfile GetUserProfileByUserId(string userId);
}