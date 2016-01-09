namespace Bungie.Models
{
    using System;

    public class RaidActivities
    {
        public long ActivityBundleHash { get; set; }
        public string RaidIdentifier { get; set; }
        public DateTime ExpirationDate { get; set; }
        public RaidActivity[] Tiers { get; set; }
        public string IconPath { get; set; }
    }
}