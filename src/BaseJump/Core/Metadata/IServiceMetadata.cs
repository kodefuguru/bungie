namespace BaseJump.Core.Metadata
{
    using System;

    internal partial interface IServiceMetadata
    {
        object Service { get; }
        Type ServiceType { get; }
        string Path { get;  }
    }
}
