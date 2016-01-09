namespace Bungie.Responses
{
    using Newtonsoft.Json;

    public class GetPostGameCarnageReportResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public Models.Activity Activity { get; set; }
    }
}