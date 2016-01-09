namespace Bungie.Definitions
{
    public class ItemCategory
    {
        public long ItemCategoryHash { get; set; }
        public string Identifier { get; set; }
        public bool Visible { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public string Description { get; set; }
        public int GrantDestinyItemType { get; set; }
        public int GrantDestinySubType { get; set; }
        public int GrantDestinyClass { get; set; }
    }
}
