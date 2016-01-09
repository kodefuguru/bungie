namespace Bungie.Definitions
{
    public class MaterialRequirement
    {
        public long ItemHash { get; set; }
        public bool DeleteOnAction { get; set; }
        public int Count { get; set; }
        public bool OmitFromRequirements { get; set; }
    }
}
