namespace Bungie.Responses
{
    using Models;
    using Newtonsoft.Json;

    public class GetCharacterInventorySummaryResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public InventorySummary Inventory { get; set; }
    }
}