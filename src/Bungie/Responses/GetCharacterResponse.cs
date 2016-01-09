namespace Bungie.Responses
{
    using Models;
    using Newtonsoft.Json;

    public class GetCharacterResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public CharacterSummary Character { get; set; }
    }
}