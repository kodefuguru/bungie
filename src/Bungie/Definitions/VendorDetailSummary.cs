namespace Bungie.Definitions
{
    public class VendorDetailSummary
    {
        public long VendorHash { get; set; }
        public string VendorName { get; set; }
        public string VendorDescription { get; set; }
        public string VendorIcon { get; set; }
        public int VendorOrder { get; set; }
        public string FactionName { get; set; }
        public string FactionIcon { get; set; }
        public long FactionHash { get; set; }
        public string FactionDescription { get; set; }
        public int ResetIntervalMinutes { get; set; }
        public int ResetOffsetMinutes { get; set; }
        public string VendorIdentifier { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public string TransitionNodeIdentifier { get; set; }
        public bool Visible { get; set; }
        public long ProgressionHash { get; set; }
        public string SellString { get; set; }
        public string BuyString { get; set; }
        public string VendorPortrait { get; set; }
        public string VendorBanner { get; set; }
        public long[] UnlockFlagHashes { get; set; }
        public long[] EnabledUnlockFlagHashes { get; set; }
        public string MapSectionIdentifier { get; set; }
        public string MapSectionName { get; set; }
        public int MapSectionOrder { get; set; }
        public bool ShowOnMap { get; set; }
        public long EventHash { get; set; }
        public long VendorCategoryHash { get; set; }
        public long[] VendorCategoryHashes { get; set; }
        public long VendorSubcategoryHash { get; set; }
    }
}
