namespace BaseJump.Core.Metadata
{
    using System;

    internal partial class ModelMetadata : IModelMetadata
    {
        public string ClassName { get; set; }
        public bool Ignore { get; set;}
        public string Format { get; set; }
        public object Model { get; set; }
        public Type ModelType { get; set; }
        public string Name { get; set; }
        public string PropertyName { get; set; }
        public Type PropertyType { get; set; }
    }

}
