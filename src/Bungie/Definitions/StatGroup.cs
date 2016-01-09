namespace Bungie.Definitions
{
    public class StatGroup
    {
        public long StatGroupHash { get; set; }
        public int MaximumValue { get; set; }
        public int UiPosition { get; set; }
        public ScaledStat[] ScaledStats { get; set; }
        public Unknown Overrides { get; set; }
    }
}
