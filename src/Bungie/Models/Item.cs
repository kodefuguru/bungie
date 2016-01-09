namespace Bungie.Models
{
    public class Item
    {
        public long ItemHash { get; set; }
        public int BindStatus { get; set; }
        public bool IsEquipped { get; set; }
        public string ItemInstanceId { get; set; }
        public int ItemLevel { get; set; }
        public int StackSize { get; set; }
        public int QualityLevel { get; set; }
        public ItemStat[] Stats { get; set; }
        public ItemStat PrimaryStat { get; set; }
        public bool CanEquip { get; set; }
        public int EquipRequiredLevel { get; set; }
        public long UnlockFlagHashRequiredToEquip { get; set; }
        public int CannotEquipReason { get; set; }
        public int DamageType { get; set; }
        public long DamageTypeHash { get; set; }
        public int DamageTypeNodeIndex { get; set; }
        public int DamageTypeStepIndex { get; set; }
        public Progression Progression { get; set; }
        public long TalentGridHash { get; set; }
        public ItemNode[] Nodes { get; set; }
        public bool UseCustomDyes { get; set; }
        public HashMap<int> ArtRegions { get; set; }
        public bool IsEquipment { get; set; }
        public bool IsGridComplete { get; set; }
        public ItemPerk[] Perks { get; set; }
        public int Location { get; set; }
        public int TransferStatus { get; set; }
        public bool Locked { get; set; }
        public bool Lockable { get; set; }
        public ItemObjective[] Objectives { get; set; }
        public int State { get; set; }
    }
}