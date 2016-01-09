namespace Bungie.Responses
{
    using Models;
    using Newtonsoft.Json;

    public class GetAccountResponse : DefinitionsResponse
    { 
        [JsonProperty("data")]
        public Account Account { get; set; }
    }
}