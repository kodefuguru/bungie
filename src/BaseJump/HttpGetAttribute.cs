namespace BaseJump
{
    using System;

    internal partial class HttpGetAttribute : HttpMethodAttribute
    {
        public HttpGetAttribute()
            : base("GET")
        {
        }
    }
}