using LHSDBFreeAgentsAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace LHSDBFreeAgentsAPI.Mappers
{
    // THIS IS MAPPER!
    public class Mapper : IMapper
    {
        public IEnumerable<PlayerResponse> ToPlayerResponse(IEnumerable<PlayerDb> players)
        {
            return players.Select(ToPlayerResponse);
        }

        public PlayerResponse ToPlayerResponse(PlayerDb playerDb)
        {
            return new PlayerResponse
            {
                UniqueID = playerDb.UniqueID,
                Name = playerDb.Name,
                URLLink = playerDb.URLLink,
                Team = playerDb.Team,
                Contract = playerDb.Contract,
                Salary = playerDb.Salary,
                OVK = playerDb.OVK,
                Position = playerDb.Position,
                IsFA = playerDb.IsFA,
                Age = playerDb.Age
            };
        }

        public IEnumerable<OfferModel> ToOfferResponse(IEnumerable<OfferDb> offers)
        {
            return offers.Select(ToOfferResponse);
        }

        public OfferModel ToOfferResponse(OfferDb playerDb)
        {
            return new OfferModel
            {
                PlayerId = playerDb.PlayerID,
                TeamId = playerDb.TeamID,
                OfferedBy = playerDb.OfferedBy,
                Amount = playerDb.Amount,
                IsOwner = playerDb.IsOwner,
                PlayerType = playerDb.PlayerType,
                PlayerName = playerDb.PlayerName,
            };
        }

        public OfferDb ToOfferDbModel(OfferModel model)
        {
            return new OfferDb
            {
                PlayerID = model.PlayerId,
                TeamID = model.TeamId,
                OfferedBy = model.OfferedBy,
                IsOwner = model.IsOwner,
                Amount = model.Amount,
                PlayerType = model.PlayerType,
                PlayerName = model.PlayerName,
            };
        }
    }
}
