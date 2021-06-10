using LHSDBFreeAgentsAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LHSDBFreeAgentsAPI.Services
{
    public interface IOfferService
    {
        public void CreateNewOffer(OfferModel model);
        public void DeleteOffer(string username, int offerId);
        public Task<IEnumerable<OfferModel>> GetAllOffersByTeam(int teamId);
        public Task<IEnumerable<OfferModel>> GetAllOffersToPlayer(int playerId);
    }
}
