using LHSDBFreeAgentsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LHSDBFreeAgentsAPI.Services
{
    public interface IPlayerService
    {
        Task<IEnumerable<PlayerResponse>> GetAllTeamPlayers(int teamId, bool faOnly);

        Task<IEnumerable<PlayerResponse>> GetAllFreeAgents();
    }
}
