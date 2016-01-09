namespace BaseJump.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    internal sealed partial class RequestModel
    {
        private object model;
        private Type modelType;

        public string Route { get; private set; }
        public string Method { get; private set; }

        private readonly IDictionary<string, string> values = new Dictionary<string, string>();

        private RequestModel(object obj)
        {
            model = obj;
            modelType = obj.GetType();
            Method = "GET";
        }

        private void BuildInitialValues()
        {
            foreach (var property in modelType.GetRuntimeProperties())
            {
                values.Add(property.Name, property.GetValue(model).ToString());
            }
        }

        private void BuildRoute()
        {
            var attributes = modelType.GetTypeInfo().CustomAttributes;
            Route = GetRawRoute(attributes) ?? model.GetType().Name;
            ReplaceRouteTokens();
        }

        private void ReplaceRouteTokens()
        {
            RouteToken token = null;
            while ((token = RouteToken.Next(Route)) != null)
            {
                if (values.ContainsKey(token.Name))
                {
                    Route = Route.Replace(token.ToString(), values[token.Name]);
                }
            }
        }
     
        private string GetRawRoute(IEnumerable<CustomAttributeData> attributes)
        {
            var data = attributes.FirstOrDefault(a => a.AttributeType == typeof(RouteAttribute));
            var attribute = data.CreateAttribute() as RouteAttribute;
            return attribute == null ? null : attribute.Route;
        }
    }
}