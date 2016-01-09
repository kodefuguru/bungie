namespace Bungie.Definitions
{
    public class EquippingBlock
    {
        public int WeaponSandboxPatternIndex { get; set; }
        public int GearArtArrangementIndex { get; set; }
        public Dye[] DefaultDyes { get; set; }
        public Dye[] LockedDyes { get; set; }
        public Dye[] CustomDyes { get; set; }
        public DyeExpression CustomDyeExpression { get; set; }
        public long WeaponPatternHash { get; set; }
        public Arrangement[] Arrangements { get; set; }
    }
}
