namespace Bungie.Models
{
    public class StatsCharacter
    {
        public long CharacterId { get; set; }
        public bool Deleted { get; set; }
        public StatsCharacterResults Results { get; set; }
        public AllTimeStats<MergedStats> Merged { get; set; }
    }
}