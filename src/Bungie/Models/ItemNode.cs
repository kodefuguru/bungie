namespace Bungie.Models
{
    public class ItemNode
    {
        public bool IsActivated { get; set; }
        public int StepIndex { get; set; }
        public int State { get; set; }
        public bool Hidden { get; set; }
        public int NodeHash { get; set; }
    }
}