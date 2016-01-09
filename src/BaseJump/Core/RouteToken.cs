namespace BaseJump.Core
{    
    internal partial class RouteToken
    {
        private readonly string token;

        public RouteToken(string token)
        {
            this.token = token;
        }

        public string Name
        {
            get
            {
                return token.Substring(1, token.Length - 2);
            }
        }

        public static RouteToken Next(string tokenizedText)
        {
            var start = tokenizedText.IndexOf('{');
            var end = tokenizedText.IndexOf('}');
            if (start >= 0 && end > start)
            {
                return new RouteToken(tokenizedText.Substring(start, end - start + 1));
            }
            return null;
        }

        public override string ToString()
        {
            return token;
        }
    }
}