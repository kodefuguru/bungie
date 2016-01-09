namespace BaseJump.Core.Metadata
{
    using System; 

    internal partial interface IModelMetadata
    {
        string ClassName { get; }
        bool Ignore { get; set; }
        string Format { get; }
        object Model { get; }
        Type ModelType { get; }
        string Name { get; }
        string PropertyName { get; }
        Type PropertyType { get; }
    }
}
