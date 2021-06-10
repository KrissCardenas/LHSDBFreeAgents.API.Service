using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using LHSDBFreeAgentsAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LHSDBFreeAgentsAPI.Repositories.DynamoDBImpl
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly DynamoDBContext _context;

        public PlayerRepository(IAmazonDynamoDB dynamoDbClient)
        {
            _context = new DynamoDBContext(dynamoDbClient);
        }

        public async Task<IEnumerable<PlayerDb>> GetAllTeamPlayers(int teamId, bool faOnly)
        {
            if (faOnly)
            {
                List<ScanCondition> conditions = new List<ScanCondition>();
                conditions.Add(new ScanCondition("Team", ScanOperator.Equal, teamId));
                conditions.Add(new ScanCondition("IsFA", ScanOperator.Equal, true));
                return await _context.ScanAsync<PlayerDb>(conditions).GetRemainingAsync();
            }
            var config = new DynamoDBOperationConfig
            {
                IndexName = "Team-OVK-index",
                BackwardQuery = true
            };

            return await _context.QueryAsync<PlayerDb>(teamId, config).GetRemainingAsync();
        }

        public async Task<IEnumerable<PlayerDb>> GetAllFreeAgents()
        {
            List<ScanCondition> conditions = new List<ScanCondition>();
            conditions.Add(new ScanCondition("IsFA", ScanOperator.Equal, true));
            return await _context.ScanAsync<PlayerDb>(conditions).GetRemainingAsync();
        }

    }
}
