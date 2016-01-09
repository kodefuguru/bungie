namespace Bungie.Responses
{
    using Models;
    using Newtonsoft.Json;

    public class GetAdvisorsResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public Advisors Advisors { get; set; }
    }
}