namespace Bungie.Models
{
    public class CharacterProgression
    {
        public Progression[] Progressions { get; set; }
        public Progression LevelProgression { get; set; }
        public int BaseCharacterLevel { get; set; }
        public bool IsPrestigeLevel { get; set; }
        public long FactionProgressionHash { get; set; }
        public float PercentToNextLevel { get; set; }
    }
}