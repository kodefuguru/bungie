namespace BaseJump.Core
{
    using System.Collections.Generic;

    internal partial class RouteRequest
    {

        private readonly Route route;
        private readonly object model;

        public RouteRequest(Route route, object model = null)
        {
            this.model = model;
            this.route = route;
        }
    }
}
