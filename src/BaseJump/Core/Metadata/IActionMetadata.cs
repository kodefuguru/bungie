namespace BaseJump.Core.Metadata
{
    using System;
    using System.Reflection;

    internal interface IActionMetadata
    {
        string Action { get; }
        HttpMethod HttpMethod { get; }
        object Service { get; }
        MethodInfo ServiceMethod { get; }
        Type ServiceType { get; }
        object Model { get; }
        Type ModelType { get; }
        string Path { get; }
    }
}
