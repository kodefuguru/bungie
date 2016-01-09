namespace Bungie.Definitions
{
    public class Card
    {
        public int CardId { get; set; }
        public string CardName { get; set; }
        public string CardIntro { get; set; }
        public string CardDescription { get; set; }
        public string UnlockHowToText { get; set; }
        public int Rarity { get; set; }
        public long UnlockFlagHash { get; set; }
        public ImagePack NormalResolution { get; set; }
        public ImagePack HighResolution { get; set; }
        public int Points { get; set; }
        public CardStatistic[] StatisticCollection { get; set; }
    }  
}