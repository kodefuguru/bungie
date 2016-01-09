namespace Bungie.Definitions
{
    public class Objective
    {
        public long ObjectiveHash { get; set; }
        public long UnlockValueHash { get; set; }
        public int CompletionValue { get; set; }
        public long VendorHash { get; set; }
        public long VendorCategoryHash { get; set; }
        public string DisplayDescription { get; set; }
        public long LocationHash { get; set; }
        public bool AllowNegativeValue { get; set; }
        public bool AllowValueChangeWhenCompleted { get; set; }
        public bool IsCountingDownward { get; set; }
    }
}
