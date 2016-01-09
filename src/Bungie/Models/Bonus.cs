namespace Bungie.Models
{
    public class Bonus
    {
        public int CardId { get; set; }

        public string CardName { get; set; }

        public string StatName { get; set; }

        public string BonusName { get; set; }

        public string BonusDescription { get; set; }

        public BonusRank BonusRank { get; set; }

        public int Value { get; set; }

        public int Threshold { get; set; }

        public Image SmallImage { get; set; }
    }
}