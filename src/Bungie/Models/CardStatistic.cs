namespace Bungie.Models
{
    public class CardStatistic
    {
        public int StatNumber { get; set; }
        public float Value { get; set; }
        public string DisplayValue { get; set; }
        public CardRank[] RankCollection { get; set; }
    }
}