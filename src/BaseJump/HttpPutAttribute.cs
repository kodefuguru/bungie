namespace BaseJump
{
    using System;

    internal partial class HttpPutAttribute : HttpMethodAttribute
    {
        public HttpPutAttribute()
            : base("PUT")
        {
        }
    }
}