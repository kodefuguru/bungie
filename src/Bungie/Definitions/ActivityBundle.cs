namespace Bungie.Definitions
{
    public class ActivityBundle
    {
        public long BundleHash { get; set; }
        public string ActivityName { get; set; }
        public string ActivityDescription { get; set; }
        public string Icon { get; set; }
        public string ReleaseIcon { get; set; }
        public int ReleaseTime { get; set; }
        public long DestinationHash { get; set; }
        public long PlaceHash { get; set; }
        public long ActivityTypeHash { get; set; }
        public long[] ActivityHashes { get; set; }
    }
}
