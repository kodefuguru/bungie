namespace Bungie.Definitions
{
    public class VendorDetail
    {
        public VendorDetailSummary Summary { get; set; }

        /// <remarks>
        /// Probably an array of hashes, but might be item objects. Need example.
        /// </remarks>
        public Unknown[] AcceptedItems { get; set; }
        public VendorDetailCategory[] Categories { get; set; }
        public string[] FailureStrings { get; set; }
        public long UnlockValueHash { get; set; }
    }
}
