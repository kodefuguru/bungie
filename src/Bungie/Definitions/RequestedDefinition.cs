namespace Bungie.Definitions
{
    public class RequestedDefinition
    {
        public long RequestedId { get; set; }
        public Activity Activity { get; set; }
        public ActivityType ActivityType { get; set; }
        public Class ClassDefinition { get; set; }
        public Gender Gender { get; set; }
        public Bucket InventoryBucket { get; set; }
        public Item InventoryItem { get; set; }
        public Progression Progression { get; set; }
        public Race Race { get; set; }
        public Stat Stat { get; set; }
        public TalentGrid TalentGrid { get; set; }
        public StatGroup StatGroup { get; set; }
        public Flag UnlockFlag { get; set; }
        public VendorDetail Vendor { get; set; }
        public Destination Destination { get; set; }
        public Place Place { get; set; }
        public Unknown DirectorBook { get; set; }
        public Unknown MaterialRequirement { get; set; }
        public Unknown SandboxPerk { get; set; }
        public Unknown ArtDye { get; set; }
        public Unknown ArtDyeChannel { get; set; }
        public ActivityBundle ActivityBundle { get; set; }
        public Unknown GearAsset { get; set; }
    }
}
