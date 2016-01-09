namespace Bungie.Models
{
    public class Nightfall : TieredActivityBundle<NightfallActivity>
    {
        public long SpecificActivityHash { get; set; }
    }
}