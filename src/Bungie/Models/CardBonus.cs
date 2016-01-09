namespace Bungie.Models
{
    public class CardBonus
    {
        public int CardId { get; set; }
        public string CardName { get; set; }
        public string StatName { get; set; }
        public string BonusName { get; set; }
        public string BonusDescription { get; set; }
        public BonusRank BonusRank { get; set; }
        public float Value { get; set; }
        public float Threshold { get; set; }
        public Image SmallImage { get; set; }
    }
}