namespace Bungie.Models
{
    public class ActivityStats
    {
        public Stat Assists { get; set; }
        public Stat Completed { get; set; }
        public Stat Deaths { get; set; }
        public Stat Kills { get; set; }
        public Stat KillsDeathRatio { get; set; }
        public Stat KillsDeathsAssists { get; set; }
        public Stat ActivityDurationSeconds { get; set; }
        public Stat CompletionReason { get; set; }
        public Stat FireTeamId { get; set; }
        public Stat PlayerCount { get; set; }
        public Stat LeaveRemainingSeconds { get; set; }
    }
}
