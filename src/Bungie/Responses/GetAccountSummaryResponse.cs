namespace Bungie.Responses
{
    using Newtonsoft.Json;
    using Models;

    public class GetAccountSummaryResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public AccountSummary AccountSummary { get; set; }
    }
}