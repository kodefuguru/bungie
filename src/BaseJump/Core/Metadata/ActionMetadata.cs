namespace BaseJump.Core.Metadata
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Conventions;

    internal partial class ActionMetadata : IActionMetadata
    {
        public string Action { get; set; }
        public HttpMethod HttpMethod { get; set; }
        public object Service { get; set; }
        public MethodInfo ServiceMethod { get; set; }
        public Type ServiceType { get; set; }
        public object Model { get; set; }
        public Type ModelType { get; set; }
        public string Path { get; set; }
    }
}
