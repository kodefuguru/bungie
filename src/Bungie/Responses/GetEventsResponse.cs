namespace Bungie.Responses
{
    using Models;
    using Newtonsoft.Json;

    public class GetEventsResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public EventSet EventSet { get; set; }
    }
}