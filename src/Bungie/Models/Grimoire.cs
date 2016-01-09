namespace Bungie.Models
{
    public class Grimoire
    {
        public int Score { get; set; }
        public Card[] CardCollection { get; set; }
        public long[] CardsToHide { get; set; }
        public CardBonus[] Bonuses { get; set; }
    }
}
