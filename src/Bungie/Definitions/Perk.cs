namespace Bungie.Definitions
{
    public class Perk
    {
        public long PerkHash { get; set; }
        public string DisplayIcon { get; set; }
        public bool IsDisplayable { get; set; }
        public Groups PerkGroups { get; set; }
    }
}
