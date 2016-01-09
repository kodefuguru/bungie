namespace Bungie
{
    using System;
    
    public class NotAuthenticatedException : Exception
    {
        public NotAuthenticatedException(string serviceName, string actionName)
            : base(String.Format("{0}.{1} requires user authentication.", serviceName, actionName))
        {
        }
    }
}
