namespace BaseJump.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal partial struct HttpMethod
    {
        public static HttpMethod Delete { get { return new HttpMethod("DELETE"); } }
        public static HttpMethod Get { get { return new HttpMethod("GET"); } }
        public static HttpMethod Post { get { return new HttpMethod("POST"); } }
        public static HttpMethod Put { get { return new HttpMethod("PUT"); } }

        private string value;      

        public HttpMethod(string value)
        {
            this.value = (value ?? String.Empty).ToString();
        }

        public override bool Equals(object other)
        {
            var type = other.GetType();
            if (type == typeof(string))
            {
                return Equals(other as string);
            }
            if (type == typeof(HttpMethod))
            {
                return Equals((HttpMethod)other);
            }
            return false;
        }

        public bool Equals(string other)
        {
            return Equals(new HttpMethod(other));
        }

        public bool Equals(HttpMethod other)
        {
            return this.ToString() == other.ToString();
        }

        public override string ToString()
        {
            return value ?? String.Empty;
        }

        public static implicit operator string(HttpMethod method)
        {
            return method.ToString();
        }
    }
}
