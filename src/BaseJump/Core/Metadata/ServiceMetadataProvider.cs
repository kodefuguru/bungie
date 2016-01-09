namespace BaseJump.Core.Metadata
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Conventions;

    internal partial class ServiceMetadataProvider : IServiceMetadataProvider
    {
        private IServicePathConvention servicePathConvention;
        private ServiceMetadata metadata;

        public ServiceMetadataProvider(IServicePathConvention servicePathConvention)
        {
            this.servicePathConvention = servicePathConvention;
        }

        public IServiceMetadata GetMetadataFor(object service)
        {
            metadata = new ServiceMetadata
            {
                Service = service,
                ServiceType = service.GetType()
            };

            SetOrderedProperties();

            return metadata;
        }

        private void SetOrderedProperties()
        {
            metadata.Path = GetPath();
        }

        private string GetPath()
        {
            var attribute = metadata.ServiceType.GetTypeInfo().GetCustomAttribute<RouteAttribute>();
            if (attribute != null)
            {
                return attribute.Route;
            }
            return servicePathConvention.From(metadata);
        }
    }
}
