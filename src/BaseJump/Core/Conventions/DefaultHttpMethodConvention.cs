namespace BaseJump.Core.Conventions
{
    using System;
    using Metadata;

    internal partial class DefaultHttpMethodConvention : IHttpMethodConvention
    {
        public HttpMethod From(ActionMetadata evidence)
        {
            return StartsWith(evidence.Action, HttpMethod.Get) ??
                   StartsWith(evidence.Action, HttpMethod.Post) ??
                   StartsWith(evidence.Action, HttpMethod.Put) ??
                   StartsWith(evidence.Action, HttpMethod.Delete) ??
                   HttpMethod.Get;
        }

        private HttpMethod? StartsWith(string action, HttpMethod method)
        {
            return action.StartsWith(method, StringComparison.CurrentCultureIgnoreCase) ? method : (HttpMethod?)null;
        }
    }
}
