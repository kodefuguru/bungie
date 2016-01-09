namespace Bungie.Models
{
    using Newtonsoft.Json;

    public class CharacterStats
    {
        [JsonProperty("STAT_DEFENSE")]
        public CharacterStat Defense { get; set; }

        [JsonProperty("STAT_INTELLECT")]
        public CharacterStat Intellect { get; set; }

        [JsonProperty("STAT_DISCIPLINE")]
        public CharacterStat Discipline { get; set; }

        [JsonProperty("STAT_STRENGTH")]
        public CharacterStat Strength { get; set; }

        [JsonProperty("STAT_LIGHT")]
        public CharacterStat Light { get; set; }

        [JsonProperty("STAT_ARMOR")]
        public CharacterStat Armor { get; set; }

        [JsonProperty("STAT_AGILITY")]
        public CharacterStat Agility { get; set; }

        [JsonProperty("STAT_RECOVERY")]
        public CharacterStat Recovery { get; set; }

        [JsonProperty("STAT_OPTICS")]
        public CharacterStat Optics { get; set; }
    }
}