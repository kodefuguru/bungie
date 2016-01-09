namespace BaseJump.Core.Metadata
{
    interface IActionMetadataProvider
    {
        IActionMetadata GetMetadataFor(object service, string action, object model);
    }
}
