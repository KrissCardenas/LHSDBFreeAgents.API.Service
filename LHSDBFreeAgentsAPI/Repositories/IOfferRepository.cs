using LHSDBFreeAgentsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LHSDBFreeAgentsAPI.Repositories
{
    public interface IOfferRepository
    {
        public Task CreateNewOffer(OfferDb model);
        public Task DeleteOffer(string username, int offerHashKey);
        public Task<IEnumerable<OfferDb>> GetAllOffersByTeam(int teamId);
        public Task<IEnumerable<OfferDb>> GetAllOffersToPlayer(int playerId);
    }
}
