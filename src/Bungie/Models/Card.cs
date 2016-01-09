namespace Bungie.Models
{
    public class Card
    {
        public int CardId { get; set; }
        public int Points { get; set; }
        public int Score { get; set; }
        public CardStatistic[] StatisticCollection { get; set; }
    }
}