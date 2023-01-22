﻿using Kahanki.Models;

namespace Kahanki.Services
{
    public interface IMatchService
    {
        List<string> GetAllCouplesByUserId(string userId);

        bool CheckIsMatchTakePlace(UserMatchAction matchAction);
    }
}
