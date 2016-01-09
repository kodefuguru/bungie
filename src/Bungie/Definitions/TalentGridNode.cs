namespace Bungie.Definitions
{
    public class TalentGridNode
    {
        public int NodeIndex { get; set; }
        public long NodeHash { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public int[] PrerequisiteNodeIndexes { get; set; }
        public int BinaryPairNodeIndex { get; set; }
        public bool AutoUnlocks { get; set; }
        public bool LastStepRepeats { get; set; }
        public bool IsRandom { get; set; }
        public ActivationRequirement RandomActivationRequirement { get; set; }
        public bool IsRandomRepurchasable { get; set; }
        public TalentGridNodeStep[] Steps { get; set; }
        public int[] ExlusiveWithNodes { get; set; }
        public int RandomStartProgressionBarAtProgression { get; set; }
        public long OriginalNodeHash { get; set; }
    }
}