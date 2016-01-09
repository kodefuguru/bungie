namespace BaseJump.Core
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Reflection;
    using System.Linq;
    using System.Threading.Tasks;
    using Metadata;

    /// <remarks>
    /// This is incomplete. Most notably I'm not handling post data yet. It's enough for now, but BaseJump isn't ready for your consumption. Sorry.
    /// </remarks>
    internal partial class RequestBuilder
    {
        private IActionMetadataProvider actionMetadataProvider;
        private IModelMetadataProvider modelMetadataProvider;
        private IServiceMetadataProvider serviceMetadataProvider;

        protected IDictionary<string, string> Headers { get; private set; }
        protected object Service { get; private set; }
        protected string Action { get; private set; }
        protected object Model { get; private set; }
        protected Type ModelType { get; private set; }
        protected Type ServiceType { get; private set; }
        protected string Route { get; private set; }
        protected HttpWebRequest Request { get; private set; }
        protected IDictionary<string, string> Values { get; private set; }
        protected ModelDictionary ModelDictionary { get; private set; }
        protected IActionMetadata ActionMetadata { get; private set; }
        protected IServiceMetadata ServiceMetadata { get; private set; }

        public RequestBuilder()
        {
            actionMetadataProvider = new ActionMetadataProvider(new Conventions.DefaultActionPathConvention(), new Conventions.DefaultHttpMethodConvention());
            modelMetadataProvider = new ModelMetadataProvider();
            serviceMetadataProvider = new ServiceMetadataProvider(new Conventions.DefaultServicePathConvention());            
            Headers = new Dictionary<string, string>();
            Values = new Dictionary<string, string>();
        }

        public void AddHeader(string key, string value)
        {
            Headers.Add(key, value);
        }

        public void AddHeaders(IDictionary<string, string> headers)
        {
            foreach (var pair in headers)
            {
                AddHeader(pair.Key, pair.Value);
            }
        }

        public async Task<WebRequest> Build(object service, string action, object model)
        {
            Service = service;
            ServiceType = service.GetType();
            Action = action;
            Model = model ?? new { };
            ModelType = Model.GetType();
            ActionMetadata = actionMetadataProvider.GetMetadataFor(Service, Action, Model);
            ServiceMetadata = serviceMetadataProvider.GetMetadataFor(Service);
            ModelDictionary = new ModelDictionary(Model); 
            
            BuildValues();
            BuildRoute();
            Request = WebRequest.CreateHttp(Route);
            Request.Method = ActionMetadata.HttpMethod;
            BuildHeaders();
            BuildContent();
            return Request;
        }

        private async void BuildContent()
        {
            if (Request.Method == "POST")
            {
                Request.ContentType = "text/json";
                using (var stream = await GetRequestStream(Request))
                {
                }
            }
        }

        private void BuildValues()
        {
            foreach (var property in ModelDictionary)
            {
                var metadata = modelMetadataProvider.GetMetadataFor(Model, property.Key);
                if (property.Value != null && !metadata.Ignore)
                {                    
                    Values.Add(property.Key, ModelValueFormatter.Format(property.Value, metadata.Format));
                }
            }
        }

        private void BuildHeaders()
        {
            foreach (var pair in Headers)
            {
                Request.Headers[pair.Key] = pair.Value;
            }
        }        

        private void BuildRoute()
        {
            var servicePath = ServiceMetadata.Path;
            var actionPath = ActionMetadata.Path;
            while (servicePath.LastIndexOf('/') == servicePath.Length)
            {
                servicePath = servicePath.Remove(servicePath.Length);
            }
            while (actionPath.IndexOf('/') == 0)
            {
                actionPath = actionPath.Remove(0, 1);
            }
            Route = String.Format("{0}/{1}", servicePath, actionPath);
            ReplaceRouteTokens();
            if (ActionMetadata.HttpMethod == HttpMethod.Get)
            {
                BuildQueryString();
            }
        }

        private void BuildQueryString()
        {            
            if (Values.Any())
            {
                var pairs = Values.Select(pair => pair.Key + "=" + pair.Value).ToArray();
                Route = Route + "?" + String.Join("&", pairs);
            }

        }

        private void ReplaceRouteTokens()
        {
            RouteToken token = null;
            while ((token = RouteToken.Next(Route)) != null)
            {
                if (Values.ContainsKey(token.Name))
                {
                    Route = Route.Replace(token.ToString(), Values[token.Name]);
                    Values.Remove(token.Name);
                }
            }
        }          

        private Type[] ModelPropertyTypes()
        {
            return ModelType.GetRuntimeProperties().Select(p => p.PropertyType).ToArray();
        }

        private Task<Stream> GetRequestStream(WebRequest request)
        {
            return Task.Factory.FromAsync<Stream>(request.BeginGetRequestStream, request.EndGetRequestStream, null);
        }
    }
}