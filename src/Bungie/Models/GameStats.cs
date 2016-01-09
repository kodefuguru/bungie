namespace Bungie.Models
{
    public class GameStats
    {
        public AllTimeStats<PvpStats> AllPvp { get; set; }
        public AllTimeStats<PatrolStats> Patrol { get; set;  }
        public AllTimeStats<RaidStats> Raid { get; set; }
        public AllTimeStats<StoryStats> Story {get; set;  }
        public AllTimeStats<StrikesStats> AllStrikes {get; set;  }
    }
}
