namespace Bungie.Models
{
    public class CharacterActivity : ActivityType
    {
        public bool IsNew { get; set; }
        public bool CanLead { get; set; }
        public bool CanJoin { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsVisible { get; set; }
    }
}