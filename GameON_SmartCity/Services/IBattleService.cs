using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameON_SmartCity.Services
{
    public interface IBattleService
    {
        Task BookBattleGame();

        Task CancelBattleGame();

        Task InviteToBattleGame();

        Task SendMessageToBattleGame();

    }
}
