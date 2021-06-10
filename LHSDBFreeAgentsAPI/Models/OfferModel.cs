using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LHSDBFreeAgentsAPI.Models
{
    public class OfferModel
    {
        public int PlayerId { get; set; }
        public int TeamId { get; set; }
        public string OfferedBy { get; set; }
        public bool IsOwner { get; set; }
        public int Amount { get; set; }
        public string PlayerType { get; set; }
        public string PlayerName { get; set; }
    }
}
