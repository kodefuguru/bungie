namespace Bungie.Models
{
    public class VendorItem
    {
        public Item Item { get; set; }
        public int VendorItemIndex { get; set; }
        public int ItemStatus { get; set; }
        public ItemCost[] Costs { get; set; }
        public UnlockStatus[] UnlockStatuses { get; set; }
        public int[] FailureIndexes { get; set; }
    }
}