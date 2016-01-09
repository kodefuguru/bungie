namespace BaseJump
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using Core;

    internal partial class Service
    {
        public IDictionary<string, string> Headers { get; private set; }

        public Service()
        {
            Headers = new Dictionary<string, string>();
        }

        private async Task<T> Deserialize<T>(Stream stream)
        {
            using (var reader = new StreamReader(stream))
            {
                var json = await reader.ReadToEndAsync();
                return Deserialize<T>(json);
            }
        }

        private T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        private Task<WebRequest> Request(object service, string methodName, object model)
        {
            var requestBuilder = new RequestBuilder();
            requestBuilder.AddHeaders(Headers);
            return requestBuilder.Build(service, methodName, model);
        }

        protected virtual Task<WebResponse> Response(WebRequest request)
        {
            return request.GetResponseAsync();
        }

        public async Task<T> Request<T>(object service, string methodName, object model = null)
        {
            var request = await Request(service, methodName, model);
            var response = await Response(request);
            return await Deserialize<T>(response.GetResponseStream());
        }
    }
}
