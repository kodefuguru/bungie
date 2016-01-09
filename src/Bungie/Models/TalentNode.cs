namespace Bungie.Models
{
    public class TalentNode
    {
        public int NodeIndex { get; set; }
        public long NodeHash { get; set; }
        public int State { get; set; }
        public string StateId { get; set; }
        public bool IsActivated { get; set; }
        public int StepIndex { get; set; }
        public Unknown[] MaterialsToUpgrade { get; set; }
        public int ActivationGridLevel { get; set; }
        public float ProgressPercent { get; set; }
        public bool Hidden { get; set; }
    }
}
