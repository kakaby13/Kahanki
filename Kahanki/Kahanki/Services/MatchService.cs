using Kahanki.Data;
using Kahanki.Models;

namespace Kahanki.Services;

public class MatchService : IMatchService
{
    private readonly ApplicationDbContext _db;

    public MatchService(ApplicationDbContext db)
    {
        _db = db;
    }

    public List<string> GetAllCouplesByUserId(string userId)
    {
        //TODO
        throw new NotImplementedException();
    }

    public bool CheckIsMatchTakePlace(UserMatchAction matchAction)
    {
        //TODO
        throw new NotImplementedException();
    }
}