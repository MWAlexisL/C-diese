﻿using System.Collections.Generic;
using System.Dynamic;
using System.Threading.Tasks;
using Models;

namespace DAO.Interfaces
{
    public interface IBetDao
    {
        void AddBet(Bet bet);
        void AddListBet(List<Bet> bets);
        Task<List<Bet>> FindFinishBets(User user, int competitionId);
        void UpdateListBet(List<Bet> bets);
        Task<ExpandoObject> FindCurrentBetsAndScheduledMatches(User user, int competitionId);
    }
}
