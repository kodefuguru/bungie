namespace Bungie.Responses
{
    using Definitions;

    public class DefinitionsResponse
    {
        public Definitions Definitions { get; set; }

        public DefinitionsResponse()
        {
            Definitions = new Definitions();
        }
    }
}
