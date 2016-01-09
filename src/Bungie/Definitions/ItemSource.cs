namespace Bungie.Definitions
{
    public class ItemSource
    {
        public int ExpansionIndex { get; set; }
        public int Level { get; set; }
        public int MinQuality { get; set; }
        public int MaxQuality { get; set; }
        public int MinLevelRequired { get; set; }
        public int MaxLevelRequired { get; set; }
        public int Exclusivity { get; set; }
        public HashMap<ComputedStat> ComputedStats { get; set; }
        public long[] SourceHashes { get; set; }
        public int[] SpawnIndexes { get; set; }
    }
}
