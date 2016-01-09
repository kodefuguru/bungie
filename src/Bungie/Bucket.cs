namespace Bungie
{
    [BaseJump.Numeric]
    public enum Bucket
    {
        None = 0,
        Artifact = 1,
        Material = 2,
        Consumable = 4,
        Mission = 8,
        Bounty = 16,
        Build = 32,
        PrimaryWeapon = 64,
        SpecialWeapon = 128,
        HeavyWeapon = 256,
        Head = 512,
        Arms = 1024,
        Chest = 2048,
        Legs = 4096,
        ClassItem = 8192,
        Ghost = 16384,
        Vehicle = 32768,
        Ship = 65536,
        Shader = 131072,
        Emblem = 262144,
    }
}
