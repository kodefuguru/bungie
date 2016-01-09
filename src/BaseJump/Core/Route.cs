namespace BaseJump.Core
{
    internal partial class Route
    {
        public string Name { get; private set; }
        public string Url { get; private set; }
        public string Method { get; private set; }

        public Route(string name, string url, string method)
        {
            Name = name;
            Url = url;
            Method = method;
        }
     
        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
