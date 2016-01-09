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

        protected BungieService(string apiKey)
        {
            service.Headers["X-API-Key"] = apiKey;
        }

        protected async Task<T> Request<T>(object model = null, [CallerMemberName] string methodName = null)
        {
            var response = await service.Request<Message<T>>(this, methodName, model);
            return response.Response;
        } 
    }
}
