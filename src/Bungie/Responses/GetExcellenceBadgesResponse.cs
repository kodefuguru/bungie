namespace Bungie.Responses
{
    using Models;
    using Newtonsoft.Json;

    public class GetExcellenceBadgesResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public ExcellenceBadges ExcellenceBadges { get; set; }
    }
}