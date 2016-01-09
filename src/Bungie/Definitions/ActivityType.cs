namespace Bungie.Definitions
{
    public class ActivityType
    {
        public long ActivityTypeHash { get; set; }
        public string Identifier { get; set; }
        public string ActivityTypeName { get; set; }
        public string ActivityTypeDescription { get; set; }
        public string Icon { get; set; }
        public string ActiveBackgroundVirtualPath { get; set; }
        public string CompletedBackgroundVirtualPath { get; set; }
        public string HiddenOverrideVirtualPath { get; set; }
        public string TooltipBackgroundVirtualPath { get; set; }
        public string EnlargedActiveBackgroundVirtualPath { get; set; }
        public string EnlargedCompletedBackgroundVirtualPath { get; set; }
        public string EnlargedHiddenOverrideVirtualPath { get; set; }
        public string EnlargedTooltipBackgroundVirtualPath { get; set; }
        public int Order { get; set; }
    }
}
