namespace BaseJump.Core.Metadata
{
    interface IModelMetadataProvider
    {
        IModelMetadata GetMetadataFor(object model, string propertyName);
    }
}
