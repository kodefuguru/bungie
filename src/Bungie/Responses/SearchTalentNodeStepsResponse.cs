namespace Bungie.Responses
{
    using Newtonsoft.Json;
    using Models;

    public class SearchTalentNodeStepsResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public TalentNodeStepsSearch Results { get; set; }
    }
}