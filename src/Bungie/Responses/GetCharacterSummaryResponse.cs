namespace Bungie.Responses
{
    using Models;
    using Newtonsoft.Json;

    public class GetCharacterSummaryResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public CharacterSummary CharacterSummary { get; set; }
    }
}