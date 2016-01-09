namespace BaseJump.Core.Metadata
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Conventions;

    internal partial class ActionMetadataProvider : IActionMetadataProvider
    {
        private ActionMetadata metadata;
        private IActionPathConvention actionPathConvention;
        private IHttpMethodConvention httpMethodConvention;

        public ActionMetadataProvider(IActionPathConvention actionPathConvention, IHttpMethodConvention httpMethodConvention)
        {
            this.actionPathConvention = actionPathConvention;
            this.httpMethodConvention = httpMethodConvention;
        }

        public IActionMetadata GetMetadataFor(object service, string action, object model)
        {
            metadata = new ActionMetadata 
            { 
                Service = service, 
                ServiceType = service.GetType(),
                Action = action, 
                Model = model ?? new { },
                ModelType = model == null ? typeof(object) : model.GetType()
            };

            SetOrderedProperties();
            
            return metadata;           
        }

        private void SetOrderedProperties()
        {
            metadata.ServiceMethod = GetServiceMethod();
            metadata.HttpMethod = GetHttpMethod();
            metadata.Path = GetPath();
        }

        private HttpMethod GetHttpMethod()
        {
            var attribute = metadata.ServiceMethod.GetCustomAttribute<HttpMethodAttribute>();
            return attribute == null ? httpMethodConvention.From(metadata) : attribute.HttpMethod;
        }

        private string GetPath()
        {
            var route = metadata.ServiceMethod.GetCustomAttribute<RouteAttribute>();
            if (route != null)
            {
                return route.Route;
            }
            return actionPathConvention.From(metadata);
        }

        private MethodInfo GetServiceMethod()
        {
            return metadata.ServiceType.GetRuntimeMethod(metadata.Action, ModelPropertyTypes()) ?? metadata.ServiceType.GetRuntimeMethods().FirstOrDefault(m => m.Name == metadata.Action);
        }

        private Type[] ModelPropertyTypes()
        {
            return metadata.ModelType.GetRuntimeProperties().Select(p => p.PropertyType).ToArray();
        }
    }
}
