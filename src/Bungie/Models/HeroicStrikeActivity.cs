namespace Bungie.Models
{
    public class HeroicStrikeActivity : ActivityType
    {
        public bool IsCompleted { get; set; }
        public int[] ActiveRewardIndexes { get; set; }
    }
}