namespace Bungie.Models
{
    public class StatsMergedCharacter
    {
        public StatsCharacterResults Results { get; set; }
        public AllTimeStats<MergedStats> Merged { get; set; }
    }
}