namespace BaseJump.Core.Metadata
{
    interface IServiceMetadataProvider
    {
        IServiceMetadata GetMetadataFor(object service);
    }
}
