namespace Bungie.Models
{
    public class CharacterCustomization
    {
        public long Personality { get; set; }

        public long Face { get; set; }

        public long SkinColor { get; set; }

        public long LipColor { get; set; }

        public long EyeColor { get; set; }

        public long HairColor { get; set; }

        public long FeatureColor { get; set; }

        public long DecalColor { get; set; }

        public bool WearHelmet { get; set; }

        public int HairIndex { get; set; }

        public int FeatureIndex { get; set; }

        public int DecalIndex { get; set; }
    }
}