namespace Bungie.Models
{
    using System;

    public class Vendor
    {
        public long VendorHash { get; set; }
        public DateTime NextRefreshDate { get; set; }
        public bool Enabled { get; set; }
        public SaleItemCategory[] SaleItemCategories { get; set; }
        public bool CanPurchase { get; set; }
        public HashMap<long> Currencies { get; set; }
    }
}
