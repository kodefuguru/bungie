namespace Bungie.Responses
{
    using Newtonsoft.Json;
    using Models;

    public class SearchItemsResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public ItemSearch Results { get; set; }
    }
}