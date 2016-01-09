namespace Bungie.Models
{
    public class WeeklyCrucible : ActivityBundle
    {
        public bool IsCompleted { get; set; }
        public int[] ActiveRewardsIndexes { get; set; }
        public int CompletionCount { get; set; }
        public int MaxCompletions { get; set; }
    }
}