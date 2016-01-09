namespace Bungie.Definitions
{
    public class CardStatistic
    {        
        public int CardId { get; set; }
        public string StatName { get; set; }
        public long AccumulatorHash { get; set; }
        public int StatNumber { get; set; }
        public CardRank[] RankCollection { get; set; }
    }
}