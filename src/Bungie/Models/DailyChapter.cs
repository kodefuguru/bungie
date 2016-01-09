namespace Bungie.Models
{
    public class DailyChapter : ActivityBundle
    {
        public bool IsCompleted { get; set; }
        public bool IsLocked { get; set; }
        public long[] TierActivityHashes { get; set; }
        public HashMap<int[]> ActiveRewardIndexes { get; set; }
    }
}