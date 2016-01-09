namespace Bungie.Models
{
    public class InventoryBucket
    {
        public Item[] Items { get; set; }
        public long BucketHash { get; set; }
    }
}