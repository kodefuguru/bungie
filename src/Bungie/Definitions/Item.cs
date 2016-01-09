namespace Bungie.Definitions
{

    public class Item
    {
        public long ItemHash { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string Icon { get; set; }
        public string SecondaryIcon { get; set; }
        public string ActionName { get; set; }
        public bool HasAction { get; set; }
        public bool DeleteOnAction { get; set; }
        public string TierTypeName { get; set; }
        public int TierType { get; set; }
        public string ItemTypeName { get; set; }
        public long BucketTypeHash { get; set; }
        public long PrimaryBaseStatHash { get; set; }
        public HashMap<ComputedStat> Stats { get; set; }
        public long[] PerkHashes { get; set; }
        public int SpecialItemType { get; set; }
        public long TalentGridHash { get; set; }
        public EquippingBlock EquippingBlock { get; set; }
        public bool HasGeometry { get; set; }
        public long StatGroupHash { get; set; }
        public int[] ItemLevels { get; set; }
        public int QualityLevel { get; set; }
        public bool Equippable { get; set; }
        public bool Instanced { get; set; }
        public long RewardItemHash { get; set; }
        public Unknown Values { get; set; }
        public int ItemType { get; set; }
        public int ItemSubType { get; set; }
        public int ClassType { get; set; }
        public ItemSource[] Sources { get; set; }
        public long[] ItemCategoryHashes { get; set; }
        public long[] SourceHashes { get; set; }
        public bool NonTransferrable { get; set; }
        public int Exclusive { get; set; }
        public int MaxStackSize { get; set; }
        public int ItemIndex { get; set; }
        public long[] SetItemHashes { get; set; }
        public long QuestlineItemHash { get; set; }
        public bool NeedsFullCompletion { get; set; }
        public long[] ObjectiveHashes { get; set; }
        public bool AllowActions { get; set; }
        public long QuestTrackingUnlockValueHash { get; set; }
        public long BountyResetUnlockHash { get; set; }
    }
}
