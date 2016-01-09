namespace Bungie.Models
{
    public class NightfallActivity : ActivityType
    {
        public long SpecificActivityHash { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsSuccessful { get; set; }
        public int[] ActiveRewardIndexes { get; set; }
        public int[] SkullIndexes { get; set; }
    }
}