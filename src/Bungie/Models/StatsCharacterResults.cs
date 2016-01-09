namespace Bungie.Models
{
    public class StatsCharacterResults
    {
        public AllTimeStats<PvpStats> AllPvp { get; set; }
        public AllTimeStats<PveStats> AllPve { get; set; }
    }
}