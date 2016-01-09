namespace Bungie.Models
{
    public class VendorWithMetadata
    {
        public Vendor Vendor { get; set; }
        public int[] FeaturedSaleIndexes { get; set; }
        public Unknown ItemMetadata { get; set; }
        public Unknown[] RelatedItemSections { get; set; }
    }
}
