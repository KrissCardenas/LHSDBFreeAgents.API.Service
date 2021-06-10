using LHSDBFreeAgentsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LHSDBFreeAgentsAPI.Repositories
{
    public interface IPlayerRepository
    {
        public Task<IEnumerable<PlayerDb>> GetAllTeamPlayers(int teamId, bool faOnly);

        public Task<IEnumerable<PlayerDb>> GetAllFreeAgents();
    }
}
