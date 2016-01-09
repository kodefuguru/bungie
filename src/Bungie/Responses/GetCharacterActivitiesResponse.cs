namespace Bungie.Responses
{
    using Models;
    using Newtonsoft.Json;

    public class GetCharacterActivitiesResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public CharacterActivities CharacterActivities { get; set; }
    }
}