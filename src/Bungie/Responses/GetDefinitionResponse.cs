namespace Bungie.Responses
{
    using Definitions;
    using Newtonsoft.Json;

    public class GetDefinitionResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public RequestedDefinition Definition { get; set; }
    }
}