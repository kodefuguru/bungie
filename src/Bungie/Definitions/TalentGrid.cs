namespace Bungie.Definitions
{
    public class TalentGrid
    {
        public long GridHash { get; set; }
        public int MaxGridLevel { get; set; }
        public int GridLevelPerColumn { get; set; }
        public long ProgressionHash { get; set; }
        public TalentGridNode[] Nodes { get; set; }
        public int CalcMaxGridLevel { get; set; }
        public int CalcProgressToMaxLevel { get; set; }
        public ExclusiveSet[] ExclusiveSets { get; set; }
        public int[] IndependentNodeIndexes { get; set; }
    }
}
