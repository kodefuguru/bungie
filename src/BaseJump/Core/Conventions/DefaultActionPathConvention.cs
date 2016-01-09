namespace BaseJump.Core.Conventions
{
    using Metadata;

    internal partial class DefaultActionPathConvention : IActionPathConvention
    {
        public string From(ActionMetadata evidence)
        {
            return evidence.Action;
        }
    }
}
