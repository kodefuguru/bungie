namespace Bungie
{
    using System;
    using BaseJump;

    /// <summary>
    /// Represents a gap in knowledge.
    /// </summary>
    /// <remarks>
    /// Typically used when an API parameter name is known but not its type.
    /// </remarks>
    [Ignore]
    public struct Unknown
    {
        public override string ToString()
        {
            return String.Empty;
        }
    }
}
