namespace Bungie.Models
{
    public class Activity
    {
        public System.DateTime Period { get; set; }
        public ActivityDetails ActivityDetails { get; set; }
        public ActivityEntry[] Entries { get; set; }
        public Unknown[] Teams { get; set; }
    }
}