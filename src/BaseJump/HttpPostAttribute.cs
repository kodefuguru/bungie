namespace BaseJump
{
    using System;

    internal partial class HttpPostAttribute : HttpMethodAttribute
    {      
        public HttpPostAttribute() : base("POST")
        {
        }
    }
}