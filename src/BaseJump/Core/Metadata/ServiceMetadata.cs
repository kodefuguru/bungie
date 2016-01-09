namespace BaseJump.Core.Metadata
{
    using System;

    internal partial class ServiceMetadata : IServiceMetadata
    {
        public object Service { get; set; }
        public Type ServiceType { get; set; }
        public string Path { get; set; }
    }  
}
