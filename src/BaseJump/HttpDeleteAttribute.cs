namespace BaseJump
{
    using System;

    internal partial class HttpDeleteAttribute : HttpMethodAttribute
    {
        public HttpDeleteAttribute()
            : base("DELETE")
        {
        }
    }
}