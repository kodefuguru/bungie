namespace Bungie.Models
{
    public class MaterialUpgrades
    {
        public long ActivityBundleHash { get; set; }
        public long MaterialItemHash { get; set; }
        public string[] ItemSoidsUpgradeable { get; set; }
    }
}