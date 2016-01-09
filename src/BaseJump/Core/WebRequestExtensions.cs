namespace BaseJump.Core
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;

    internal static class WebRequestExtensions
    {
        internal static Task<WebResponse> GetResponseAsync(this WebRequest request)
        {
            return Task.Factory.FromAsync<WebResponse>(request.BeginGetResponse, request.EndGetResponse, null);
        }
    }
}
