namespace Bungie.Definitions
{
    public class Progression
    {
        public long ProgressionHash { get; set; }
        public string Name { get; set; }
        public int Scope { get; set; }
        public bool RepeatLastStep { get; set; }
        public string Icon { get; set; }
        public ProgressionStep[] Steps { get; set; }
    }
}
