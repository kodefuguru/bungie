namespace Bungie.Responses
{
    using Newtonsoft.Json;
    using Models;

    public class GetUniqueWeaponsStatsResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public WeaponsStats WeaponsStats { get; set; }
    }
}