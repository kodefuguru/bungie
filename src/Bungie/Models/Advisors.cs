namespace Bungie.Models
{
    using System;

    public class Advisors
    {
        public long NightfallActivityHash { get; set; }
        public long[] HeroicStrikeHashes { get; set; }
        public long[] DailyChapterHashes { get; set; }
        public DateTime NightfallResetDate { get; set; }
        public DateTime HeroicStrikeResetDate { get; set; }
        public DateTime DailyChapterResetDate { get; set; }
        public long DailyCrucibleHash { get; set; }
        public DateTime DailyCrucibleResetDate { get; set; }
        public int[] NightfallRewardIndexes { get; set; }
        public int[] DailyCrucibleRewardIndexes { get; set; }
        public HashMap<int[]> HeroicStrikeRewardIndexes { get; set; }
        public HashMap<int[]> DailyChapterRewardIndexes { get; set; }
        public ArenaActivity[] Arena { get; set; }
        public EventSet Events { get; set; }
        public Nightfall Nightfall { get; set; }
        public HeroicStrike HeroicStrike { get; set; }
        public DailyChapter DailyChapter { get; set; }
        public DailyCrucible DailyCrucible { get; set; }
        public ArmsDay ArmsDay { get; set; }
        public WeeklyCrucible[] WeeklyCrucible { get; set; }
    }
}