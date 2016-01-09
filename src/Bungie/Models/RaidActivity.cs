namespace Bungie.Models
{
    public class RaidActivity
    {
        public long ActivityHash { get; set; }
        public int StepsComplete { get; set; }
        public int StepsTotal { get; set; }
        public string DifficultyIdentifier { get; set; }
        public int[] ActiveRewardIndexes { get; set; }
    }
}