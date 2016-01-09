namespace Bungie.Definitions
{
    public class Event
    {
        public long EventHash { get; set; }
        public string EventIdentifier { get; set; }
        public string BackgroundImageWeb { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public bool ShowNagMessage { get; set; }
        public long ProgressionHash { get; set; }
        public long VendorHash { get; set; }
        public long FactionHash { get; set; }
        public string BackgroundImageMobile { get; set; }
        public long ActiveUnlockValueHash { get; set; }
        public long[] BountyHashes { get; set; }
        public long[] QuestHashes { get; set; }
    }
}
