namespace Bungie.Models
{
    public class ArenaActivity : ActivityType
    {
        public string IconPath { get; set; }
        public ArenaRound[] Rounds { get; set; }
        public bool BossFight { get; set; }
        public int[] BossSkulls { get; set; }
        public int[] ActiveRewardIndexes { get; set; }
        public bool IsCompleted { get; set; }
    }
}