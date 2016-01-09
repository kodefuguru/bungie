namespace Bungie.Responses
{
    using Models;
    using Newtonsoft.Json;

    public class GetCharacterProgressionResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public CharacterProgression CharacterProgression { get; set; }
    }
}