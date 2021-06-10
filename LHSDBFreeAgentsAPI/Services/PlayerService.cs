using LHSDBFreeAgentsAPI.Mappers;
using LHSDBFreeAgentsAPI.Models;
using LHSDBFreeAgentsAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LHSDBFreeAgentsAPI.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;

        public PlayerService(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<PlayerResponse>> GetAllTeamPlayers(int teamId, bool faOnly)
        {
            var response = await _playerRepository.GetAllTeamPlayers(teamId, faOnly);

            return _mapper.ToPlayerResponse(response);
        }

        public async Task<IEnumerable<PlayerResponse>> GetAllFreeAgents()
        {
            var response = await _playerRepository.GetAllFreeAgents();
            return _mapper.ToPlayerResponse(response);
        }
    }
}
