namespace Bungie.Responses
{
    using Newtonsoft.Json;
    using Models;

    public class GetItemDetailResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public ItemDetail ItemDetail { get; set; }
    }
}