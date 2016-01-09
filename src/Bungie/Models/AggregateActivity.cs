namespace Bungie.Models
{
    public class AggregateActivity
    {
        public Stat FastestCompletionSecondsForActivity { get; set; }
        public Stat ActivityCompletions { get; set; }
        public Stat ActivityDeaths { get; set; }
        public Stat ActivityKills { get; set; }
        public Stat ActivitySecondsPlayed { get; set; }
        public Stat ActivityWins { get; set; }
        public Stat ActivityKillsDeathsRatio { get; set; }
        public Stat ActivityAssists { get; set; }
        public Stat ActivityKillsDeathsAssists { get; set; }
        public Stat ActivityPrecisionKills { get; set; }
        public Stat ActivityGatesHit { get; set; }
    }
}