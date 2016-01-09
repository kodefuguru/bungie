namespace Bungie.Definitions
{
    public class ScaledStat
    {
        public long StatHash { get; set; }
        public int MaximumValue { get; set; }
        public bool DisplayAsNumeric { get; set; }
        public WeightedValue[] DisplayInterpolation { get; set; }
    }
}