namespace Bungie.Models
{
    public class DailyCrucible : ActivityBundle
    {
        public bool IsCompleted { get; set; }
        public int[] ActiveRewardIndexes { get; set; }
    }
}