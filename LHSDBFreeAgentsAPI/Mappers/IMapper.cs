using LHSDBFreeAgentsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LHSDBFreeAgentsAPI.Mappers
{
    public interface IMapper
    {
        IEnumerable<PlayerResponse> ToPlayerResponse(IEnumerable<PlayerDb> players);
        IEnumerable<OfferModel> ToOfferResponse(IEnumerable<OfferDb> offers);

        OfferDb ToOfferDbModel(OfferModel model);

    }
}
