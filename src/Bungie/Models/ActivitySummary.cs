namespace Bungie.Models
{
    using System;

    public class ActivitySummary
    {
        public DateTime Period { get; set; }
        public ActivityDetails ActivityDetails { get; set; }
        public ActivityStats Values { get; set; }
    }
}