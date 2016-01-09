namespace Bungie.Responses
{
    using Models;
    using Newtonsoft.Json;

    public class GetTriumphsResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public Triumphs Triumphs { get; set; }
    }
}