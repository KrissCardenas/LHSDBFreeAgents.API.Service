using System;
using Amazon.DynamoDBv2.DataModel;

namespace LHSDBFreeAgentsAPI.Models
{
    [DynamoDBTable("Offers")]
    public class OfferDb
    {
        [DynamoDBHashKey]
        public int PlayerID { get; set; }
        [DynamoDBGlobalSecondaryIndexHashKey]
        public int TeamID { get; set; }
        public string OfferedBy { get; set; }
        public bool IsOwner { get; set; }
        public int Amount { get; set; }
        public string PlayerType { get; set; }
        public string PlayerName { get; set; }
    }
}
