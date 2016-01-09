namespace Bungie.Models
{
    using System;

    public class ArmsDay
    {
        public bool Active { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime NextStartDate { get; set; }
        public bool CanPlaceOrder { get; set; }
        public VendorItem[] TestWeapons { get; set; }
        public ArmsDayOrder[] Orders { get; set; }
        public ArmsDayRedemption Redemptions { get; set; }
        public long VendorHash { get; set; }
        public ArmsDayOrder[] PurchasedOrders { get; set; }
    }
}
