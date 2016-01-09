namespace Bungie.Responses
{
    using Newtonsoft.Json;
    using Models;
    
    public class GetXurResponse : DefinitionsResponse
    {
        [JsonProperty("data")]
        public Vendor Xur { get; set; }
    }
}