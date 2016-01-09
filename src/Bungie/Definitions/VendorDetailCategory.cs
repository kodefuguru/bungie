namespace Bungie.Definitions
{
    public class VendorDetailCategory
    {
        public long CategoryHash { get; set; }
        public string DisplayTitle { get; set; }
        public long OverlayCurrencyItemHash { get; set; }
        public int QuantityAvailable { get; set; }
        public bool ShowUnavailableItems { get; set; }
        public bool HideIfNoCurrency { get; set; }
        public string BuyStringOverride { get; set; }
        public string OverlayTitle { get; set; }
        public string OverlayChoice { get; set; }
        public string OverlayIcon { get; set; }
        public bool HasOverlay { get; set; }
        public bool HideFromRegularPurchase { get; set; }
    }
}
