namespace Bungie.Models
{
    public class Progression
    {
        public int DailyProgress { get; set; }
        public int WeeklyProgress { get; set; }
        public int CurrentProgress { get; set; }
        public int Level { get; set; }
        public int Step { get; set; }
        public int ProgressToNextLevel { get; set; }
        public int NextLevelAt { get; set; }
        public long ProgressionHash { get; set; }
    }
}