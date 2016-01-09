namespace Bungie.Responses
{
    using Models;
    using Newtonsoft.Json;

    public class GetAggregateActivityStatsResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public AggregateActivities AggregateActivityStats { get; set; }
    }
}