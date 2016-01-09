namespace BaseJump
{
    using System;
    using Core;

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    internal partial class HttpMethodAttribute : Attribute
    {
        public HttpMethod HttpMethod { get; private set; }

        public HttpMethodAttribute(string value)
        {
            HttpMethod = new HttpMethod(value);
        }
    }
}
