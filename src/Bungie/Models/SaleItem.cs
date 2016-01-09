namespace Bungie.Models
{
    public class SaleItem
    {
        public long ItemHash { get; set; }
        public Item Item { get; set; }
        public int VendorItemIndex { get; set; }
        public int ItemStatus { get; set; }
        public ItemCost[] Costs { get; set; }
        public Unknown[] RequiredUnlockFlags { get; set; }
        public UnlockStatus[] UnlockStatuses { get; set; }
        public int[] FailureIndexes { get; set; }
    }
}