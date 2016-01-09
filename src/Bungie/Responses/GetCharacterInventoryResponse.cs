namespace Bungie.Responses
{
    using Models;
    using Newtonsoft.Json;

    public class GetCharacterInventoryResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public CharacterInventory CharacterInventory { get; set; }
    }
}