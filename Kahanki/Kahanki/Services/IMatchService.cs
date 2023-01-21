using Kahanki.Models;

namespace Kahanki.Services
{
    public interface IMatchService
    {
        void GetAllMatchesByUserId(string userId);

        bool CheckIsMatchTakePlace(UserMatchAction matchAction);
    }
}
