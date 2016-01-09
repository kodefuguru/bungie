namespace Bungie
{
    /// <summary>
    /// Services enforce specific count values and will choose the next highest allowed if passed an unsupported value.
    /// This enum codifies allowed values.
    /// </summary>
    [BaseJump.Numeric]
    public enum Count
    {
        Ten = 10,
        TwentyFive = 25,
        Fifty = 50,
        OneHundred = 100,
        FiveHundred = 500
    }
}
