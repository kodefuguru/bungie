namespace Bungie.Models
{
    public class RewardClaimSale
    {
        public long CurrencyItemHash { get; set; }
        public VendorItem[] SaleItems { get; set; }
    }
}