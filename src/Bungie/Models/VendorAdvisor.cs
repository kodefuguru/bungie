namespace Bungie.Models
{
    using System;

    public class VendorAdvisor
    {
        public string RotationAckId { get; set; }
        public bool NeedsAck { get; set; }
        public DateTime NextRefreshDate { get; set; }
        public HashMap<RewardClaimSale> RewardClaimSales { get; set; }
        public Progression Progression { get; set; }
    }
}
