namespace Bungie
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using BaseJump;
    using Responses;

    public abstract class BungieService
    {
        private readonly Service service = new Service();

        protected string Root { get; private set; }

        protected BungieService(string apiKey)
        {
            Root = String.Format("https://www.bungie.net/platform/{0}/", GetType().Name.Replace("Service", String.Empty));
            service.Headers["X-API-Key"] = apiKey;
        }

        protected async Task<T> Request<T>(object model = null, [CallerMemberName] string methodName = null)
        {
            var response = await service.Request<Message<T>>(this, methodName, model);
            return response.Response;
        } 
    }
}
