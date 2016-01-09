namespace Bungie.Models
{
    public class ActivityEntry
    {
        public int Standing { get; set; }
        public Stat Score { get; set; }
        public long CharacterId { get; set; }
        public ActivityStats Values { get; set; }
        public ActivityEntryExtended Extended { get; set; }
    }
}