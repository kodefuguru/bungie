namespace Bungie.Models
{
    public class ItemSummary
    {
        public long ItemHash { get; set; }
        public long ItemId { get; set; }
        public int Quantity { get; set; }
        public int DamageType { get; set; }
        public long DamageTypeHash { get; set; }
        public bool IsGridComplete { get; set; }
        public int TransferStatus { get; set; }
        public int State { get; set; }
        public int CharacterIndex { get; set; }
        public long BucketHash { get; set; }
    }
}
